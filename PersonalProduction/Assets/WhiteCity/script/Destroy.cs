using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (hit.gameObject.tag == "flg")
		{
			//消える
			Destroy(hit.gameObject, 0.0f);
			score.scoreNum++;
			RandomPosition.countBall++;
		}
	}
}
