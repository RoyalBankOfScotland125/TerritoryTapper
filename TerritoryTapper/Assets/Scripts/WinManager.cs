using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinManager : MonoBehaviour {
	public Transform Blue;
	public Transform Red;
	public GameObject areaMan;
	public ChangeTerritory terrMan;
	public Animator winAnim;
	StatsManager stats;
	// Use this for initialization
	void Start() {
		winAnim = GetComponent<Animator>();
		stats = GameObject.Find("PersistantStats").GetComponent<StatsManager>();
	}

	// Update is called once per frame
	void Update () {
		if(Red.position.x == 0 || Blue.position.x == 0){
			if(Red.position.x == 0) {
				terrMan.canTap = false;
				winAnim.SetBool("RedWins", true);
				stats.IncRedWins (1);
			}
			else if(Blue.position.x == 0) {
				terrMan.canTap = false;
				winAnim.SetBool("BlueWins", true);
			}
			Blue.Translate (.001f, 0, 0, Space.World);
			Red.Translate (.001f, 0, 0, Space.World);
			terrMan.stopTime ();
			stats.IncGamesPlayed(1);
			stats.IncBlueTaps(terrMan.blueTaps);
			stats.IncRedTaps(terrMan.redTaps);
			stats.IncGameTime(terrMan.gameTime);

		}
	}
}
