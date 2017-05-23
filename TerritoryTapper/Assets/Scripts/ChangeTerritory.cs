
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTerritory : MonoBehaviour {

	Vector3 touchPosWorld;
	public GameObject red;
	public GameObject blue;
	public bool canTap;
	public int redTaps;
	public int blueTaps;
	public bool hasTapped;
	float gameTime;
	//Change me to change the touch phase used.
	TouchPhase touchPhase = TouchPhase.Ended;

	void Awake(){
		canTap = true;
	}

	void Start(){
		blueTaps = 0;
		redTaps = 0;
		gameTime = 0f;
		hasTapped = false;
	}
	void Update() {
		if (hasTapped) {
			gameTime += Time.deltaTime;
		}
		//We check if we have more than one touch happening.
		//We also check if the first touches phase is Ended (that the finger was lifted)
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == touchPhase) {
			//We transform the touch position into word space from screen space and storeit.
			touchPosWorld = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

			Vector2 touchPosWorld2D = new Vector2(touchPosWorld.x, touchPosWorld.y);

			//We now raycast with this information. If we have hit something we can process it.
			RaycastHit2D hitInformation = Physics2D.Raycast(touchPosWorld2D, Camera.main.transform.forward);

			if (hitInformation.collider != null) {
				
				//We should have hit something with a 2D Physics collider!
				GameObject touchedObject = hitInformation.transform.gameObject;

				if (touchedObject == red && canTap) {
					red.transform.Translate (.25f, 0f, 0f, Space.World);
					blue.transform.Translate (.25f, 0f, 0f, Space.World);
					Handheld.Vibrate();
					redTaps++;
				}
				if (touchedObject == blue && canTap) {
					blue.transform.Translate (-.25f, 0f, 0f, Space.World);
					red.transform.Translate (-.25f, 0f, 0f, Space.World);
					Handheld.Vibrate();
					blueTaps++;
				}
				hasTapped = true;
			}
		}
	}
}