using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		// �Փ˂��������Player�^�O���t���Ă���Ƃ�
		if (hit.gameObject.tag == "flg")
		{
			//������
			Destroy(hit.gameObject, 0.0f);
			score.scoreNum++;
			RandomPosition.countBall++;
		}
	}
}
