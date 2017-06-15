using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveOptions : MonoBehaviour {
	public Material leftColor;
	public Material rightColor;
	public Image RightPicker;
	public Image LeftPicker;
	// Use this for initialization

	void Start () {
		RightPicker = GameObject.FindGameObjectWithTag ("RightColor").GetComponentsInChildren<Image> ()[0];
		LeftPicker = GameObject.FindGameObjectWithTag ("LeftColor").GetComponentsInChildren<Image> ()[0];
	}

	public void OnClick () {
		leftColor.color = RightPicker.color;
		rightColor.color = LeftPicker.color;
	}

}
