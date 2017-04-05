using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinManager : MonoBehaviour {
	public Transform Blue;
	public Transform Red;
	public GameObject areaMan;
	public ChangeTerritory terrMan;
	Animator winAnim;
	
	// Use this for initialization
	void Awake() {
		winAnim = GetComponent<Animator>();
		terrMan = areaMan.GetComponent<ChangeTerritory>();
	}
	
	/*
	void Start() {
		terrMan = areaMan.GetComponent<ChangeTerritory>();
	}
	*/
	// Update is called once per frame
	void Update () {
		if(Red.position.x == 0) {
			terrMan.canTap = false;
			winAnim.SetBool("RedWins", true);
			
		}
		else if(Blue.position.x == 0) {
			terrMan.canTap = false;
			winAnim.SetBool("BlueWins", true);
		}
	}
}
