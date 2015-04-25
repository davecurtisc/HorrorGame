using UnityEngine;
using System.Collections;

public class Door_Room1 : MonoBehaviour {
	

	public bool withinRadius_room1Door = false;

	public static bool can_Exit = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		can_Exit = Candle_off.can_open_door;

		if (withinRadius_room1Door = true && can_Exit == true && Input.GetKeyDown (KeyCode.E)) {
			Application.LoadLevel("Hallway2");

			print("should load new level");

		}

		//print (clearance);
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_room1Door = true;
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_room1Door = false;
	}
}
