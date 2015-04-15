using UnityEngine;
using System.Collections;

public class Attic_Door : MonoBehaviour {

	public bool withinRadius_door = false;

	public bool checker = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (withinRadius_door == true) {
			checker = true;
		}

		if (checker == true && Input.GetKeyDown(KeyCode.E)) {
			Application.LoadLevel("Hallway");
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_door = true;
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_door = false;
	}
}
