using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarTestDlg : MonoBehaviour
{

    [SerializeField] Text m_txtResult = null;
    [SerializeField] Button m_btnResult = null;
    [SerializeField] Button m_btnClear = null;
    [SerializeField] Scrollbar m_scrollbarNum = null;

    [SerializeField] int m_mValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        m_btnResult.onClick.AddListener(OnClicked_Result);
        m_btnClear.onClick.AddListener(OnClicked_Clear);

        Initialize();
    }

    public void Initialize()
    {
        m_scrollbarNum.value = m_mValue;
        m_scrollbarNum.value = 0;
    }

    public void OnValueChanged_ScrollNumber()
    {
        string strValue = "" + (int)(m_scrollbarNum.value*100);
        //string strValue = "" + m_scrollbarNum.value;
        //string str = m_scrollbarNum.value.ToString();//숫자를 문자열로 바꿔주는 것
        m_txtResult.text = strValue;


    }
    public void OnClicked_Result()
    {
        float iValue = (int)(m_scrollbarNum.value*100);
        //float iValue = m_scrollbarNum.value;
        string strResult = "현재 진행된 값은<color=#ff0000> " + iValue + " </color>입니다";
        m_txtResult.text = strResult;
    }
    public void OnClicked_Clear()
    {
        m_txtResult.text = "정리 됐습니다";
        //m_txtResult.text = "";
    }
    // Update is called once per frame
    void Update()
    {

    }
}

