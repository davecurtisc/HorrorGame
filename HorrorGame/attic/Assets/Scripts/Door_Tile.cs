using UnityEngine;
using System.Collections;

public class Door_Tile : MonoBehaviour {

	public static bool can_Leave;

	public bool withinRadius_Tiledoor;

	public GameObject locked_Gui;

	// Use this for initialization
	void Start () {

		can_Leave = false;

		locked_Gui.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		can_Leave = Key_Active_Script.has_Key;

		if (withinRadius_Tiledoor == true && can_Leave == true && Input.GetKeyDown (KeyCode.E)) {
		
			Application.LoadLevel("Hallway4");
		}

		if (withinRadius_Tiledoor == true && can_Leave == false && Input.GetKeyDown (KeyCode.E)) {
		
			locked_Gui.SetActive(true);

			StartCoroutine(locked_leaves());
		}
	
	}

	IEnumerator locked_leaves()
	{
		
		yield return new WaitForSeconds(2);
		
		locked_Gui.SetActive(false);
		//Do Function here...
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_Tiledoor = true;
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_Tiledoor = false;
	}
}
