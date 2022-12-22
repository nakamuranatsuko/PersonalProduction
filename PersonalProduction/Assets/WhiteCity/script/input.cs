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
    }

    public void InputText()
    {
        //テキストにinputFieldの内容を反映
        string input = inputField.GetComponent<TMP_InputField>().text;
        text.text = input;

    }
}
