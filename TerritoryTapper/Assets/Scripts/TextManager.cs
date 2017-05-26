using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {
	GameObject statsObject;
	StatsManager stats;
	private Text gamesPlayed;
	private Text redTaps;
	private Text blueTaps;
	private Text totalTaps;
	private Text timePlayed;
	private Text avgTapsTime;
	private Text avgGameTime;
	// Use this for initialization
	void Start () {
		statsObject = GameObject.Find ("PersistantStats");
		stats = statsObject.GetComponent<StatsManager> ();
		gamesPlayed = GameObject.FindWithTag ("GamesPlayed").GetComponent<Text>();
		redTaps = GameObject.FindGameObjectWithTag ("RedTaps").GetComponent<Text> ();
		blueTaps = GameObject.FindGameObjectWithTag ("BlueTaps").GetComponent<Text> ();
		totalTaps = GameObject.FindGameObjectWithTag ("TotalTaps").GetComponent<Text> ();
		timePlayed = GameObject.FindGameObjectWithTag ("TimePlayed").GetComponent<Text> ();
		avgTapsTime = GameObject.FindGameObjectWithTag ("AvgTapsTime").GetComponent<Text> ();
		avgGameTime = GameObject.FindGameObjectWithTag ("AvgGameTime").GetComponent<Text> ();
		UpdateText ();
	}
	
	// Update is called once per frame
	public void UpdateText () {
		Debug.Log("it worked");
		gamesPlayed.text = stats.GetGamesPlayed() + " Games Played";
		redTaps.text = stats.GetRedTaps() + " Red Taps";
		blueTaps.text = stats.GetBlueTaps() + " Blue Taps";
		totalTaps.text = stats.GetBlueTaps() + stats.GetRedTaps() + " Total Taps";
		timePlayed.text = stats.GetGameTime () / 60 + " Minutes Played";
		avgTapsTime.text = stats.GetRedTaps() + stats.GetBlueTaps() / (stats.GetGameTime () / 60) + " Average Taps per Minute";
		avgGameTime.text = stats.GetGamesPlayed() / (stats.GetGameTime () / 60) + " Average Game Time (Seconds)";
	}
}
