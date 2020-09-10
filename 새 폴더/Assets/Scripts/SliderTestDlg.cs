using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTestDlg : MonoBehaviour
{

    [SerializeField] Text m_txtResult = null;
    [SerializeField] Button m_btnResult = null;
    [SerializeField] Button m_btnClear = null;
    [SerializeField] Slider m_sliderNum = null;

    [SerializeField] int m_MinValue = 0;
    [SerializeField] int m_MaxValue = 100;

    // Start is called before the first frame update
    void Start()
    {
        m_btnResult.onClick.AddListener(OnClicked_Result);
        m_btnClear.onClick.AddListener(OnClicked_Clear);
 
        Initialize();
    }

    public void Initialize()
    {
        m_sliderNum.minValue = m_MinValue;
        m_sliderNum.maxValue = m_MaxValue;
        m_sliderNum.value = 0;
    }

    public void OnValueChanged_SliderNumber()
    {
        string strValue = "" + m_sliderNum.value;
        //string str = m_sliderNum.value.ToString();//숫자를 문자열로 바꿔주는 것
        m_txtResult.text = strValue;

       
    }
    public void OnClicked_Result()
    {
        float fValue = m_sliderNum.value;
        string strResult= "현재 진행된 값은<color=#ff0000> " + fValue + " </color>입니다";
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
