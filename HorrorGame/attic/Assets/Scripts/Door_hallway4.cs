using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Door_hallway4 : MonoBehaviour {
	
	private bool withinRadius_D1;
	private bool withinRadius_D2;
	private bool withinRadius_D3;
	private bool withinRadius_D4;
	private bool withinRadius_D5;
	
	public bool canopen = false;
	
	public GameObject how_Enter;
	public GameObject door_Locked;
	
	//public AudioClip door_creak;
	
	// Use this for initialization
	void Start () {
		how_Enter.SetActive (false);
		door_Locked.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (withinRadius_D1 == true) {
			
			canopen = true;
		}
		
		if (withinRadius_D2 == true) {
			
			canopen = true;
		}
		
		if (withinRadius_D3 == true) {
			
			canopen = true;
		}
		
		if (withinRadius_D4 == true) {
			
			canopen = true;
		}
		
		if (withinRadius_D5 == true) {
			
			canopen = true;
		}
		
		// to open
		
		if (withinRadius_D1 == true && Input.GetKeyDown (KeyCode.E)) {
			
			
			//Application.LoadLevel ("Room1"); 
			//audio.PlayOneShot(door_creak, 1.0f);
			
			how_Enter.SetActive (false);
			door_Locked.SetActive(true);
			StartCoroutine(lockdoor_leaves());
		}
		
		if (withinRadius_D2 == true && Input.GetKeyDown (KeyCode.E)) {
			
			
			//Application.LoadLevel ("Room2"); 
			//audio.PlayOneShot(door_creak, 1.0f);
			
			how_Enter.SetActive (false);
			door_Locked.SetActive(true);
			StartCoroutine(lockdoor_leaves());
		}
		
		if (withinRadius_D3 == true && Input.GetKeyDown (KeyCode.E)) {
			
			
			//Application.LoadLevel ("Tile_Puzzle"); 
			//audio.PlayOneShot(door_creak, 1.0f);

			how_Enter.SetActive (false);
			door_Locked.SetActive(true);
			StartCoroutine(lockdoor_leaves());
			
		}
		
		if (withinRadius_D4 == true && Input.GetKeyDown (KeyCode.E)) {
			
			
			//Application.LoadLevel ("First_Floor_Alpha"); 
			//audio.PlayOneShot(door_creak, 1.0f);
			
			Application.LoadLevel ("First_Floor_Alpha"); 
		}
		
		if (withinRadius_D5 == true && Input.GetKeyDown (KeyCode.E)) {
			
			
			//Application.LoadLevel ("First_Floor_Alpha"); 
			//audio.PlayOneShot(door_creak, 1.0f);
			print("this door does not open");
			
			how_Enter.SetActive (false);
			door_Locked.SetActive(true);
			StartCoroutine(lockdoor_leaves());
		}
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "D1") {
			withinRadius_D1 = true;
			how_Enter.SetActive (true);
		}
		if (other.gameObject.tag == "D2") {
			withinRadius_D2 = true;
			how_Enter.SetActive (true);
		}
		if (other.gameObject.tag == "D3") {
			withinRadius_D3 = true;
			how_Enter.SetActive (true);
		}
		if (other.gameObject.tag == "D4") {
			withinRadius_D4 = true;
			how_Enter.SetActive (true);
		}
		if (other.gameObject.tag == "D5") {
			withinRadius_D5 = true;
			how_Enter.SetActive (true);
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "D1") {
			withinRadius_D1 = false;
			how_Enter.SetActive (false);
			
		}
		if (other.gameObject.tag == "D2") {
			withinRadius_D2 = false;
			how_Enter.SetActive (false);
		}
		if (other.gameObject.tag == "D3") {
			withinRadius_D3 = false;
			how_Enter.SetActive (false);
		}
		if(other.gameObject.tag == "D4"){
			withinRadius_D4 = false;
			how_Enter.SetActive (false);
		}
		if(other.gameObject.tag == "D5"){
			withinRadius_D5 = false;
			how_Enter.SetActive (false);
		}
	}
	
	IEnumerator lockdoor_leaves()
	{
		
		yield return new WaitForSeconds(1);
		
		door_Locked.SetActive(false);
		//Do Function here...
	}
}
