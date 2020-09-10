using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToggleGroupTestDlg : MonoBehaviour
{
    [SerializeField] Text m_txtResult = null;
    [SerializeField] ToggleGroup m_ToggleGroup = null;
    [SerializeField] Button m_btnResult = null;
    string m_sValue = "";
    void Imitialize()
    {

    }

    static string[] aName = { " 사과 ", " 배 ", " 오렌지 " };
    // Start is called before the first frame update
    void Start()
    {
        m_btnResult.onClick.AddListener(OnClicked_Result);
        m_sValue = " 사과 ";
    }


    public void OnClicked_Result()
    {
        string strResult = "당신이 선택한 과일은 "+ m_sValue+" 입니다";
        m_txtResult.text = strResult;

 
        //m_txtResultText.text = "좋아하는 과일이 없습니다";
        //return;
    }

    public void OnChanged_Toggle(int index)
    {
        m_sValue = aName[index];
    }
  
    public void OnClicked_Clear()
    {
        m_ToggleGroup.SetAllTogglesOff();
        m_txtResult.text = "초기화 되었습니다";
    }
    // Update is called once per frame
    void Update()
    {

    }
}
