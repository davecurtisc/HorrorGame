using UnityEngine;
using System.Collections;

public class alpha : MonoBehaviour {
	

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Alpha0))
			Application.LoadLevel ("Start_Screen");
		if (Input.GetKeyDown(KeyCode.Alpha1))
			Application.LoadLevel ("Attic");
		if (Input.GetKeyDown(KeyCode.Alpha2))
			Application.LoadLevel ("Hallway");
		if (Input.GetKeyDown(KeyCode.Alpha3))
			Application.LoadLevel ("Room1");
		if (Input.GetKeyDown(KeyCode.Alpha4))
			Application.LoadLevel ("Hallway2");
		if (Input.GetKeyDown(KeyCode.Alpha5))
			Application.LoadLevel ("Room2");
		if (Input.GetKeyDown(KeyCode.Alpha6))
			Application.LoadLevel ("Hallway3");
		if (Input.GetKeyDown(KeyCode.Alpha7))
			Application.LoadLevel ("Tile_Puzzle");
		if (Input.GetKeyDown(KeyCode.Alpha8))
			Application.LoadLevel ("Hallway5");
		if (Input.GetKeyDown(KeyCode.Alpha9))
			Application.LoadLevel ("First_Floor_Alpha");
		if (Input.GetKeyDown(KeyCode.Escape))
			Application.Quit ();

	}
}
