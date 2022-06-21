using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public float m_CloseDistance = 8f;

    private GameObject m_Player;

    private Rigidbody2D m_Rigidbody;

    public float moveSpeed;
    
    private bool m_Follow;

    public Transform m_PlayerPos;

    private Vector3 m_Target;

    private Vector3 m_MovementPos;

    LayerMask m_LayerMask;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(m_MovementPos);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, m_LayerMask))
        {
            transform.LookAt(hit.point);
        }

        if (m_Follow == true)
        {

            //Patrol();
            //Debug.Log("Start patrol");

            m_MovementPos = m_PlayerPos.position;
            Vector3 direction = (m_PlayerPos.position - transform.position).normalized;
            
            if (direction.x > 0)
            {

                transform.localRotation = Quaternion.Euler(0, 180, 0);

            }
            else if (direction.x < 0)
            {

                transform.localRotation = Quaternion.Euler(0, 0, 0);

            }

            transform.position = Vector3.MoveTowards(transform.position, m_MovementPos, moveSpeed * Time.deltaTime);

        }
        else if (m_Follow == false)
        {

            return;

        }

        float distance = (m_Player.transform.position - transform.position).magnitude;

        if (distance > m_CloseDistance)
        {

            

        }

    }

    private void FixedUpdate()
    {

        

    }

    private void Awake()
    {

        m_Player = GameObject.FindGameObjectWithTag("Player");
        m_Rigidbody = GetComponent<Rigidbody2D>();
        m_Follow = false;
        LayerMask m_LayerMask = LayerMask.GetMask("Wall");

    }

    private void OnEnable()
    {
        
        m_Rigidbody.isKinematic = false;

    }

    private void OnDisable()
    {
        
        m_Rigidbody.isKinematic = true;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Player")
        {

            m_Follow = true;
            

        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "Player")
        {

            m_Follow = false;

        }

    }

    /*private void Patrol()
    {

        if (transform.position == PointA.position)
        {

            transform.localRotation = Quaternion.Euler(0, 0, 0);
            m_Target = PointB.position;

        }
        
        if (transform.position == PointB.position)
        {

            transform.localRotation = Quaternion.Euler(0, 180, 0);
            m_Target = PointA.position;           

        }

        transform.position = Vector3.MoveTowards(transform.position, m_Target, moveSpeed * Time.deltaTime);

    }*/

}
