using UnityEngine;
using System.Collections;

public class Start_Game : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) 
		{
			Application.LoadLevel("Controls");
			
			print("Attic should load");
		}
	}
}
