using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTestDlg: MonoBehaviour
{

    public Text m_ResultText = null;
    public InputField m_InputName = null;
    public Button m_btnStart = null;

    // Start is called before the first frame update
    void Start()
    {
        m_btnStart.onClick.AddListener(OnClicked_Start);
        //initialize();
    }

    public void OnClicked_Start()
    {
        string sValue = m_InputName.text;

        if (m_InputName.text == "")
        //if (sValue == "")   
        {
            m_ResultText.text = "입력한 내용이 없습니다";
            return;
        }
        string sRes = "당신이 입력한 이름은"+"<color=#000000>"+ sValue + "</color>"+"입니다";
        m_ResultText.text = sRes;
    }

    public void OnClicked_Clear()
    {
        m_ResultText.text = "정리 됐습니다";
        m_InputName.text="";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
