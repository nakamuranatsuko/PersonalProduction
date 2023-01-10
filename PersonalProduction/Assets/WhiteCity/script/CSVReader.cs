using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using System;
using TMPro;

public class CSVReader : MonoBehaviour
{
    public TextAsset csvFile;
    public static List<string[]> csvDatas = new List<string[]>();
    public Encoding encoding;
    public int num;
    //public int[] min;
    //public int[] time;

    //public static int t_1;
    //public static int t_2;
    //public static int t_3;

    //public TextMeshProUGUI text_1;
    //public TextMeshProUGUI text_2;
    //public TextMeshProUGUI text_3;
    //public TextMeshProUGUI nametext_1;
    //public TextMeshProUGUI nametext_2;
    //public TextMeshProUGUI nametext_3;

    void Start()
    {
        this.encoding = Encoding.GetEncoding("utf-8");
        csvFile = Resources.Load("Ranking_table") as TextAsset;
        StringReader reader = new StringReader(csvFile.text);

        // , で分割しつつ一行ずつ読み込み
        // リストに追加していく
        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            csvDatas.Add(line.Split(','));
            num++;
        }


        //min = new int[num];//要素数
        //time = new int[num];//要素数

        //for (int i = 1; i < num; i++)
        //{
        //    string csvtext = CSVReader.csvDatas[i][3];
        //    min[i] = int.Parse(csvtext);
        //}

        //Array.Copy(min, time, min.Length);
        //Array.Sort(min);

        //for (int i = 1; i < num; i++)
        //{
        //    if (min[1] == time[i]) t_1 = i;
        //    if (min[2] == time[i]) t_2 = i;
        //    if (min[3] == time[i]) t_3 = i;
        //}

        //Debug.Log(csvDatas[1][1]);//csvDatas[行][列]
    }

    //void Update()
    //{
    //    nametext_1.text = csvDatas[t_1][0];
    //    text_1.text = csvDatas[t_1][1] + ":" + csvDatas[t_1][2];

    //    nametext_2.text = csvDatas[t_2][0];
    //    text_2.text = csvDatas[t_2][1] + ":" + csvDatas[t_2][2];

    //    nametext_3.text = csvDatas[t_3][0];
    //    text_3.text = csvDatas[t_3][1] + ":" + csvDatas[t_3][2];
    //}
}
