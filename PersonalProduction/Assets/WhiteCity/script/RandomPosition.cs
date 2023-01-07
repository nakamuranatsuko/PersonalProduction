using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    [SerializeField]
    [Tooltip("��������͈�A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("��������͈�B")]
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
            // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
            float x = Random.Range(rangeA.position.x, rangeB.position.x);
            // rangeA��rangeB��y���W�͈͓̔��Ń����_���Ȑ��l���쐬
            float y = Random.Range(rangeA.position.y, rangeB.position.y);
            // rangeA��rangeB��z���W�͈͓̔��Ń����_���Ȑ��l���쐬
            float z = Random.Range(rangeA.position.z, rangeB.position.z);

            number = Random.Range(0, CubePrefabs.Length);

            // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
            Instantiate(CubePrefabs[number], new Vector3(x, y, z), CubePrefabs[number].transform.rotation);
            objNum += 1;
        }
    }
}
