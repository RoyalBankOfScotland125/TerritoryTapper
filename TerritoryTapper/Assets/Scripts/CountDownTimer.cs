using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour {

	public float countdown;
	int countInc;
	Text countDownText;

	void Start () {
		countDownText = GetComponent<Text> ();

		countInc = 0;
	}
		

	void Update () {


		if () {

			countDownText.text = countdown - ((int)changeSecond) + "";


		}
		Debug.Log (countdown - ((int)changeSecond));
		if (countdown - ((int)changeSecond) == 0) {
			
			countdownAnim.SetBool ("counterDone", true);
			gameObject.SetActive (false);
		}

	}


}
