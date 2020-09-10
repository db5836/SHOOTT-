using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToggleTestDig : MonoBehaviour
{
    [SerializeField] Text m_txtResultText = null;
    [SerializeField] Toggle m_ToggleApple = null;
    [SerializeField] Toggle m_ToggleOrange = null;
    [SerializeField] Toggle m_TogglePear = null;
    [SerializeField] Button m_btnResult = null;

    void Imitialize()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
       m_btnResult.onClick.AddListener(OnClicked_Result);
    }
    public void OnClicked_Result()
    {
        string strValue = "";

        if (m_ToggleApple.isOn == true) 
        {
            strValue += " 사과 ";
        }
        if (m_TogglePear.isOn == true)
        {
            strValue += " 배 ";
        }
        if (m_ToggleOrange.isOn == true)
        {
            strValue += " 오렌지 ";
        }

        string strResult = "당신이 좋아하는 과일은 "  + strValue + " 입니다";

        m_txtResultText.text = strResult;

        //m_txtResultText.text = "좋아하는 과일이 없습니다";
        //return;
    }
    public void OnValueChanged_Value(int idx)
    {

    }
    public void OnClicked_Clear()
    {
        m_txtResultText.text = "";
        m_ToggleApple.isOn = false;
        m_ToggleOrange.isOn = false;
        m_TogglePear.isOn = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
