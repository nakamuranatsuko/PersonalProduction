using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class RankingButton : MonoBehaviour
{
    public void OnClickRankingButton()
    {
        SceneManager.LoadScene("Ranking");
    }
}
