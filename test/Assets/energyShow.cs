using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energyShow : MonoBehaviour
{
    public Text m_MyText;

    void Start()
    {
        //Text sets your text to say this message
        m_MyText = GetComponent<Text>();
    }

    void Update()
    {
        m_MyText.text = "体力值：" + Global.p.energy;
    }
}
