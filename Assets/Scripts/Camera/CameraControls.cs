using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{

    public float m_DampTime = 0.2f;

    public Transform m_target;

    private Vector2 m_MoveVelocity;
    private Vector2 m_DesiredPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {

        m_target = GameObject.FindGameObjectWithTag("Player").transform;

    }

    private void FixedUpdate()
    {

        Move();

    }

    private void Move()
    {
        
        m_DesiredPosition = m_target.position;
        transform.position = Vector2.SmoothDamp(transform.position, m_DesiredPosition, ref m_MoveVelocity, m_DampTime);

    }

}
