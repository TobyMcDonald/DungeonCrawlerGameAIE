using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public float m_StartHealth;

    private float m_CurrentHealth;

    private bool m_Dead;

    public GameObject hit;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
     
        if (m_Dead == true)
        {

            Death();

        }

    }

    public void TakeDamage(float amount)
    {

        m_CurrentHealth -= amount;

        if (m_CurrentHealth <= 0)
        {

            m_Dead = true;

        }

    }

    private void OnEnable()
    {

        m_CurrentHealth = m_StartHealth;
        m_Dead = false;

    }

    private void Death()
    {

        gameObject.SetActive(false);

    }

}
