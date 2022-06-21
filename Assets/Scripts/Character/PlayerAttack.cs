using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public GameObject m_attack;

    private bool m_isAttacking;

    public float m_Damage = 5;

    private bool m_CanAttack = false;

    // Start is called before the first frame update
    void Start()
    {

        m_attack.SetActive(false);

    }

    private void Awake()
    {

        

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (m_CanAttack == true)
            {

                m_isAttacking = true;
                Attacking();

            }
            
        }             



    }

    private void Attacking()
    {
        m_attack.SetActive(true);

        if (m_isAttacking == true)
        {
           
            GameObject instance = Instantiate(m_attack, transform.position, Quaternion.identity, transform);

            

            //instance.transform.rotation = Quaternion.Euler(0, 0, m_attackRotation);

            //instance.transform.rotation = Quaternion.Euler(0, 0, Input.mousePosition.z);

            //set rotation of instance here
            Destroy(instance, 0.2f);
            m_isAttacking = false;

        }       
   

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Sword sword = collision.gameObject.GetComponent<Sword>();
        if (sword)
        {

            Destroy(collision.gameObject);

            m_CanAttack = true;

        }

    }

}
