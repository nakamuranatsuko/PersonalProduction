using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeCount : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    public static int minute;
    public static float seconds;
    public float oldSeconds;//‘O‚ÌUpdate‚ÌŽž‚Ì•b”
    public bool flg;

    void Start()
    {
        minute = 0;
        seconds = 0f;
        oldSeconds = 0f;
        flg = true;
    }

    void Update()
    {
        if (flg)
        {
            seconds += Time.deltaTime;

            if (seconds >= 60f)
            {
                minute++;
                seconds = seconds - 60;
            }

            if ((int)seconds != (int)oldSeconds)
            {
                timeText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
            }

            oldSeconds = seconds;
        }

        if (score.scoreNum == 30) flg = false;
    }
}
