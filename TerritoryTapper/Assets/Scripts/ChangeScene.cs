using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void OnClick() {
		switch (name) {
		case "Play": 
			SceneManager.LoadScene ("PlayField");
			break;
		case "Back":
			SceneManager.LoadScene ("MainMenu");
			break;
		case "Stats":
			SceneManager.LoadScene ("StatsMenu");
			//GameObject.Find ("TextManager").GetComponent<TextManager> ().UpdateText ();
			break;
		case "Options":
			SceneManager.LoadScene ("OptionsMenu");
			break;
		default:
			break;	
		}
	}


	// Update is called once per frame
	void Update () {
		
	}
}
