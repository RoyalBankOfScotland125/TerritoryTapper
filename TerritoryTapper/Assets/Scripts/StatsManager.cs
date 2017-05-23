using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour {

	private int gamesPlayed;
	private int redTapsTotal;
	private int blueTapsTotal;
	private int redTotalWins;
	private float totalGameTime;

	// Use this for initialization
	 void Start () {
		DontDestroyOnLoad (gameObject);
		if (PlayerPrefs.HasKey ("totalGames"))
			gamesPlayed = PlayerPrefs.GetInt ("totalGames");
		else
			gamesPlayed = 0;
		
		if (PlayerPrefs.HasKey ("redTTaps"))
			redTapsTotal = PlayerPrefs.GetInt ("redTTaps");
		else
			redTapsTotal = 0;
		
		if (PlayerPrefs.HasKey ("blueTTaps"))
			blueTapsTotal = PlayerPrefs.GetInt ("blueTTaps");
		else
			blueTapsTotal = 0;
		
		if (PlayerPrefs.HasKey ("redWins"))
			redTotalWins = PlayerPrefs.GetInt ("redWins");
		else
			redTotalWins = 0;

		if (PlayerPrefs.HasKey ("gameTime"))
			totalGameTime = PlayerPrefs.GetFloat ("gameTime");
		else
			totalGameTime = 0f;
	}
	
	public int GetGamesPlayed(){
		return gamesPlayed;
	}

	public void IncGamesPlayed(int add){
		gamesPlayed += add;
		PlayerPrefs.SetInt ("totalGames", gamesPlayed);
		PlayerPrefs.Save ();
	}

	public int GetRedTaps(){
		return redTapsTotal;
	}

	public void IncRedTaps(int add){
		redTapsTotal += add;
		PlayerPrefs.SetInt ("redTTaps", redTapsTotal);
		PlayerPrefs.Save ();
	}

	public int GetBlueTaps(){
		return blueTapsTotal;	
	}

	public void IncBlueTaps(int add){
		blueTapsTotal += add;
		PlayerPrefs.SetInt ("blueTTaps", blueTapsTotal);
		PlayerPrefs.Save ();
	}

	public int GetRedWins(){
		return redTotalWins;
	}

	public void IncRedWins(int add){
		redTotalWins += add;
		PlayerPrefs.SetInt ("redWins", redTotalWins);
		PlayerPrefs.Save ();
	}

	public float GetGameTime(){
		return totalGameTime;
	}

	public void IncGameTime(float add){
		totalGameTime += add;
		PlayerPrefs.SetFloat("gameTime", totalGameTime);
		PlayerPrefs.Save ();
	}
		
}
