using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public float m_StartHealth;

    private float m_CurrentHealth;

    private bool m_Dead;

    public Image m_HealthBar;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {

            m_CurrentHealth -= 10; 
            UpdateHealthUI();

            if (m_CurrentHealth <= 0)
            {

                m_Dead = true;

            }

        }

        if (m_Dead == true)
        {

            Dead();

        }

    }

    private void OnEnable()
    {

        m_CurrentHealth = m_StartHealth;
        m_Dead = false;

        UpdateHealthUI();

    }

    private void UpdateHealthUI()
    {

        m_HealthBar.fillAmount = m_CurrentHealth / m_StartHealth;

    }

    private void Dead()
    {



    }

}
