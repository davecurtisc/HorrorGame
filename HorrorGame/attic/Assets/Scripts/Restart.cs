using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	// check for which room the player just left

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) 
		{
			Application.LoadLevel("Room2");

			print("Room2 should load");
		}
	}
}
