using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class input : MonoBehaviour
{
    //オブジェクトと結びつける
    public TMP_InputField inputField;
    public TextMeshProUGUI text;

    void Start()
    {
        //Componentを扱えるようにする
        text = text.GetComponent<TextMeshProUGUI>();
        inputField = GetComponent<TMP_InputField>();
        InitInputField();
    }

    public void InputText()
    {
        //テキストにinputFieldの内容を反映
        //string input = inputField.text;
        text.text = inputField.text;

    }

    public void InitInputField()
    {
        // 値をリセット
        inputField.text = "";
        // フォーカス
        inputField.ActivateInputField();
    }
}
