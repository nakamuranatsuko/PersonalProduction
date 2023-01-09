using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		// Õ“Ë‚µ‚½‘Šè‚ÉPlayerƒ^ƒO‚ª•t‚¢‚Ä‚¢‚é‚Æ‚«
		if (hit.gameObject.tag == "flg")
		{
			//Á‚¦‚é
			Destroy(hit.gameObject, 0.0f);
			score.scoreNum++;
			RandomPosition.countBall++;
		}
	}
}
