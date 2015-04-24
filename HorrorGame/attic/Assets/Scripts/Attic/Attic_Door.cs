using UnityEngine;
using System.Collections;

public class Attic_Door : MonoBehaviour {

	public bool withinRadius_door = false;

	public bool checker = false;

	public bool engaged = false;

	public static bool attic_key = false;

	public GameObject door_locked;
	public GameObject door_text;

	// Use this for initialization
	void Start () {
	
		//attic_key = Box2.found_the_Key;

		door_locked.SetActive (false);
		door_text.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		attic_key = Box2.found_the_Key;

		if (withinRadius_door == true && attic_key == true) {
			checker = true;
		}

		if (checker == true && withinRadius_door == true && Input.GetKeyDown(KeyCode.E)) {
			Application.LoadLevel("Hallway");
		}

		if (withinRadius_door == true && attic_key == false && Input.GetKeyDown (KeyCode.E)) {

			door_text.SetActive(false);
			door_locked.SetActive(true);

			StartCoroutine(locked_leaves());
		}

	}

	IEnumerator locked_leaves()
	{
		
		yield return new WaitForSeconds(2);
		
		door_locked.SetActive(false);
		//Do Function here...
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_door = true;
			door_text.SetActive(true);
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_door = false;
			door_text.SetActive(false);
	}
}
