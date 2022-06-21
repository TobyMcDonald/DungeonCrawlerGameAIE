using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{

    public float m_Damage = 5;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {


        
    }

    /*private void OnCollisionEnter2D(Collision2D other)
    {

        Rigidbody2D targetRigidbody = other.gameObject.GetComponent<Rigidbody2D>();

        if (targetRigidbody != null)
        {

            EnemyHealth enemyHealth = targetRigidbody.GetComponent<EnemyHealth>();

            if (enemyHealth != null)
            {

                enemyHealth.TakeDamage(m_Damage);

            }

        }

    }*/

    //This will let the slash hit the enemies
    private void OnTriggerEnter2D(Collider2D other)
    {

        Rigidbody2D targetRigidbody = other.gameObject.GetComponent<Rigidbody2D>();

        if (targetRigidbody != null)
        {

            EnemyHealth enemyHealth = targetRigidbody.GetComponent<EnemyHealth>();

            if (enemyHealth != null)
            {

                enemyHealth.TakeDamage(m_Damage);

            }

        }

    }

}
