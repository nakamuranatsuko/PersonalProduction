using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public static int scoreNum = 0;
    public TextMeshProUGUI scoretext;

    void Start()
    {
        scoreNum = 0;
        scoretext.text = "score:" + scoreNum.ToString();
    }

    void Update()
    {
        scoretext.text = "score:" + scoreNum.ToString();
    }
}
