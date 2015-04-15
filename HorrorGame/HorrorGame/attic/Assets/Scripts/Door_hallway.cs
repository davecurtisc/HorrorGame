﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Door_hallway : MonoBehaviour {

	private bool withinRadius_D1;
	public bool canopen = false;
	
	public Text output;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
		if (withinRadius_D1 == true) {
			output.text = "Press E to enter";
			canopen = true;
		}

		if (canopen == true && Input.GetKeyDown (KeyCode.E)) {
			Application.LoadLevel ("Room1"); 
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "D1")
			withinRadius_D1 = true;
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "D1")
			withinRadius_D1 = false;
	}
}
