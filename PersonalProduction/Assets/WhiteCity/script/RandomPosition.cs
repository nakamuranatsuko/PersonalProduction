using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    [SerializeField]
    [Tooltip("生成する範囲A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("生成する範囲B")]
    private Transform rangeB;

    public int num = 30;
    public int objNum = 0;
    public GameObject[] CubePrefabs;
    public int number;

    // Update is called once per frame
    void Update()
    {
        if (num != objNum)
        {
            // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
            float x = Random.Range(rangeA.position.x, rangeB.position.x);
            // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
            float y = Random.Range(rangeA.position.y, rangeB.position.y);
            // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
            float z = Random.Range(rangeA.position.z, rangeB.position.z);

            number = Random.Range(0, CubePrefabs.Length);

            // GameObjectを上記で決まったランダムな場所に生成
            Instantiate(CubePrefabs[number], new Vector3(x, y, z), CubePrefabs[number].transform.rotation);
            objNum += 1;
        }
    }
}
