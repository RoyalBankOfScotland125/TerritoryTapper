using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

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
			break;
		case "Options":
				GameObject.Find ("PersistantStats").GetComponent<StatsManager> ().Reset ();
				Debug.Log ("Playerprefs deleted");
			break;
		default:
			break;	
		}
	}
}
