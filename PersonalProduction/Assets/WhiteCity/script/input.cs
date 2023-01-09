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
    public static string name;

    void Start()
    {
        //Componentを扱えるようにする
        text = text.GetComponent<TextMeshProUGUI>();
        inputField = GetComponent<TMP_InputField>();
        InitInputField();
        name = "";
    }

    public void InputText()
    {
        //テキストにinputFieldの内容を反映
        text.text = inputField.text;
        name = text.text;

    }

    public void InitInputField()
    {
        // 値をリセット
        inputField.text = "";
        // フォーカス
        inputField.ActivateInputField();
    }
}
