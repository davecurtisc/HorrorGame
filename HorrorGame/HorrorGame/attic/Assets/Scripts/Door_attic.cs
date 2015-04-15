using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Door_attic : MonoBehaviour {

	private static int doorkey;
	private bool withinRadius;
	public bool canopen = false;

	public Text output;

	public bool failedaccess = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		doorkey = KeyCount.keyCount;

		if (doorkey == 1) {
			canopen = true;

		}

		if (withinRadius == true && failedaccess == false) {
			output.text = "Press E to enter";

		}

		if (withinRadius == true && canopen == false && Input.GetKey (KeyCode.E)) {
			output.text = "Locked";
			failedaccess = true;
		
		}

		if (withinRadius == true && canopen == true && Input.GetKey (KeyCode.E)) {
			print("door should open");
			Application.LoadLevel("Hallway");

		}

	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius = true;
	}
		
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius = false;
	}
}
