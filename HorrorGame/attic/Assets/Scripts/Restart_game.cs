using UnityEngine;
using System.Collections;

public class Restart_game : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) 
		{
			Application.LoadLevel("Start_Screen");
			
			print("Start should load");
		}
	}
}
