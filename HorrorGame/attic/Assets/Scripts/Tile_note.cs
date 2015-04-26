using UnityEngine;
using System.Collections;

public class Tile_note : MonoBehaviour {

	public GameObject note;

	public bool withinRadius_note;


	// Use this for initialization
	void Start () {

		note.SetActive (false);

	
	}
	
	// Update is called once per frame
	void Update () {

		if (withinRadius_note == true && Input.GetMouseButtonDown (0)) {
		
			note.SetActive(true);
		}
	
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_note = true;
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_note = false;
	}
}
