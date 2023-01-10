using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public static int scoreNum = 0;
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI endText;

    void Start()
    {
        scoreNum = 0;
        scoretext.text = "獲得ボール数:" + scoreNum.ToString();
        endText.gameObject.SetActive(false);
    }

    void Update()
    {
        scoretext.text = "獲得ボール数:" + scoreNum.ToString();

        if (scoreNum == 30)
        {
            StartCoroutine(display());
        }
    }

    IEnumerator display()
    {
        endText.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("result");
    }
}
