using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Image W;
    public Image A;
    public Image S;
    public Image D;
    public Image GotSword;

    public GameObject m_TutorialPanel;

    // Start is called before the first frame update
    void Start()
    {
       
        m_TutorialPanel.gameObject.SetActive(false);
        W.gameObject.SetActive(false);
        A.gameObject.SetActive(false);
        S.gameObject.SetActive(false);
        D.gameObject.SetActive(false);
        GotSword.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
