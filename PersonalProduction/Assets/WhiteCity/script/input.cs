using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class input : MonoBehaviour
{
    //�I�u�W�F�N�g�ƌ��т���
    public TMP_InputField inputField;
    public TextMeshProUGUI text;

    void Start()
    {
        //Component��������悤�ɂ���
        text = text.GetComponent<TextMeshProUGUI>();
        inputField = GetComponent<TMP_InputField>();
        InitInputField();
    }

    public void InputText()
    {
        //�e�L�X�g��inputField�̓��e�𔽉f
        //string input = inputField.text;
        text.text = inputField.text;

    }

    public void InitInputField()
    {
        // �l�����Z�b�g
        inputField.text = "";
        // �t�H�[�J�X
        inputField.ActivateInputField();
    }
}
