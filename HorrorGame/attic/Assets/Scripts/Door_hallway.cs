using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Door_hallway : MonoBehaviour {

	private bool withinRadius_D1;
	private bool withinRadius_D2;

	public bool canopen = false;
	
	public Text output;

	//public AudioClip door_creak;

	// Use this for initialization
	void Start () {
		//door_creak = GetComponent<AudioSource>;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (withinRadius_D1 == true) {
			output.text = "Press E to enter";
			canopen = true;
		}

		if (withinRadius_D2 == true) {
			output.text = "Press E to enter";
			canopen = true;
		}

		if (withinRadius_D1 == true && Input.GetKeyDown (KeyCode.E)) {


			Application.LoadLevel ("Room1"); 
			//audio.PlayOneShot(door_creak, 1.0f);
		}

		if (withinRadius_D2 == true && Input.GetKeyDown (KeyCode.E)) {
			
			
			Application.LoadLevel ("Room2"); 
			//audio.PlayOneShot(door_creak, 1.0f);
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "D1")
			withinRadius_D1 = true;

		if(other.gameObject.tag == "D2")
			withinRadius_D2 = true;

	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "D1")
			withinRadius_D1 = false;

		if(other.gameObject.tag == "D2")
			withinRadius_D2 = false;
	}
}
