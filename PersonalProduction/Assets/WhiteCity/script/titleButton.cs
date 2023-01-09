using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class titleButton : MonoBehaviour
{
    public void OnClickTitleButton()
    {
        SceneManager.LoadScene("title");
    }
}
