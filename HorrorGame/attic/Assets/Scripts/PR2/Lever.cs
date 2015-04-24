using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour {

	public bool isOn;

	// Use this for initialization
	void Start () 
	{
		isOn = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ActivateLever()
	{
		isOn = true;
		// Play animation
	}


}
