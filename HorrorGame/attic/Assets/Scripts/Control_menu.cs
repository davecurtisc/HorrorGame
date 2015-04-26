using UnityEngine;
using System.Collections;

public class Control_menu : MonoBehaviour {

	public GameObject spacebarGui;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Space)) {
		
			Application.LoadLevel("Attic");
		}

		if(Time.fixedTime%2<1)
		{
			spacebarGui.SetActive(true);
		}
		else{
			spacebarGui.SetActive(false);
		}
	}


}
