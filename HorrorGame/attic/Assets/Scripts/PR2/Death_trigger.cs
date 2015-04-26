using UnityEngine;
using System.Collections;

public class Death_trigger : MonoBehaviour {

	public bool alive = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (alive == false) {
			Application.LoadLevel("Room2");
		}
	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "Player")
			alive = false;
	}
}
