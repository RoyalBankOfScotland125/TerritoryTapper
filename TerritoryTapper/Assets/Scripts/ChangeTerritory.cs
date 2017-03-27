using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTerritory : MonoBehaviour {

	Vector3 touchPosWorld;
	public GameObject red;
	public GameObject blue;
	//Change me to change the touch phase used.
	TouchPhase touchPhase = TouchPhase.Ended;

	void Update() {
		//We check if we have more than one touch happening.
		//We also check if the first touches phase is Ended (that the finger was lifted)
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == touchPhase) {
			//We transform the touch position into word space from screen space and storeit.
			Debug.Log("something worked");
			touchPosWorld = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

			Vector2 touchPosWorld2D = new Vector2(touchPosWorld.x, touchPosWorld.y);

			//We now raycast with this information. If we have hit something we can process it.
			RaycastHit2D hitInformation = Physics2D.Raycast(touchPosWorld2D, Camera.main.transform.forward);

			if ( hitInformation.collider != null) {
				Debug.Log ("object found");
				//We should have hit something with a 2D Physics collider!
				GameObject touchedObject = hitInformation.transform.gameObject;

				if (touchedObject == red) {
					red.transform.Translate (.5f, 0f, 0f, Space.World);
					blue.transform.Translate (.5f, 0f, 0f, Space.World);
				}
				if (touchedObject == blue) {
					blue.transform.Translate (-.5f, 0f, 0f, Space.World);
					red.transform.Translate (-.5f, 0f, 0f, Space.World);
				}
				//touchedObject should be the object someone touched.
				Debug.Log("Touched " + touchedObject.transform.name);
			}
		}
	}
}