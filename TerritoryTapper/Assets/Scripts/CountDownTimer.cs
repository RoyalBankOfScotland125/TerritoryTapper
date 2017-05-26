using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour {

	public float countdown;
	int countInc;
	Text countDownText;
	Animator countAnim;

	void Start () {
		countDownText = GetComponent<Text> ();
		countAnim = GetComponentInParent<Animator> ();
		countDownText.text = countdown + "";
	}
		

	void Update () {
		if(!(countdown <= 0f))
		{
			countDownText.text = (int) countdown + 1 + "";
			countdown -= Time.deltaTime;
		}
		else{
			gameObject.SetActive (false);
			countAnim.SetBool ("Counting", false);
		}

	}


}
