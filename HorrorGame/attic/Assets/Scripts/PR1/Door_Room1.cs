using UnityEngine;
using System.Collections;

public class Door_Room1 : MonoBehaviour {
	

	public bool withinRadius_room1Door = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (withinRadius_room1Door = true && Input.GetKeyDown (KeyCode.E)) {
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
