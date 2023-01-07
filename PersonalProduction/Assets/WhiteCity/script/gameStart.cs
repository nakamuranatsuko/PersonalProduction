using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class gameStart : MonoBehaviour
{

    public TextMeshProUGUI numText;

    void Start()
    {
        numText.text = "";
        GetComponent<Button>().interactable = true;
    }

    public void OnClickStartButton()
    {
        GetComponent<Button>().interactable = false;
        StartCoroutine(CountdownCoroutine());
    }

    IEnumerator CountdownCoroutine()
    {
        numText.gameObject.SetActive(true);

        numText.text = "3";
        yield return new WaitForSeconds(1.0f);

        numText.text = "2";
        yield return new WaitForSeconds(1.0f);

        numText.text = "1";
        yield return new WaitForSeconds(1.0f);

        SceneManager.LoadScene("game");
        yield return new WaitForSeconds(1.0f);

        numText.text = "";
        numText.gameObject.SetActive(false);
    }

}
