using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class startButton : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("game");
    }
}
