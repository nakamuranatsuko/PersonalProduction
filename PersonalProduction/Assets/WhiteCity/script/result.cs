using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class result : MonoBehaviour
{
    public TextMeshProUGUI timetext;
    public TextMeshProUGUI nametext;
    public int ru_minute;
    public float ru_seconds;
    public int ru_time;

    void Start()
    {
        ru_minute = TimeCount.minute;
        ru_seconds = TimeCount.seconds;
        ru_time = ru_minute * 60 + (int)ru_seconds;

        string st_name = input.name;
        string st_m = ru_minute.ToString();
        int int_s = (int)ru_seconds;
        string st_s = int_s.ToString();
        string st_t = ru_time.ToString();

        List<string[]> datas = new List<string[]>();
        datas.Add(new string[] { st_name, st_m, st_s, st_t });

        List<string> lines = new List<string>();
        foreach (var data in datas)
        {
            lines.Add(string.Join(",", data));
        }

        //// .csv�Ƃ��t�@�C����Assets/Settings����擾���邪�A
        //// System.IO.Directory.GetFiles���\�b�h�ł��������擾����B
        //string[] filepaths = System.IO.Directory.GetFiles("Assets/Resources", "*.csv");
        //foreach (string filepath in filepaths)
        //{
        //    // .csv�g���q�t�@�C���ȊO�͖���
        //    if (System.IO.Path.GetExtension(filepath) != ".csv")
        //    {
        //        continue;
        //    }

        //    using (var stream = new System.IO.FileStream(
        //            filepath,
        //            System.IO.FileMode.Create
        //    ))
        //    {
        // �����œǂݍ��񂾃t�@�C���̏���������

        //���X�g�̓��e���t�@�C��(CSV)�̖����ɒǉ�����
        File.AppendAllLines(@"Ranking_table.csv", lines);
        //    }
        //}
    }

    void Update()
    {
        timetext.text = ru_minute.ToString("00") + ":" + ((int)ru_seconds).ToString("00");
        nametext.text = input.name;
    }
}
