using UnityEngine;
using System.Collections;

public class Box2 : MonoBehaviour {
	
	private bool withinRadius_crate;
	
	public GameObject to_Search;
	public GameObject found_Key;

	
	public bool searching = false;
	
	public bool engaged = false;

	public static bool found_the_Key = false;
	
	// Use this for initialization
	void Start () {
		
		to_Search.SetActive (false);

		found_Key.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (withinRadius_crate == true && engaged == false) {
			to_Search.SetActive (true);
			
			print ("should be told how to search");
			
			searching = true;
		}
		
		if (searching == true && Input.GetKeyDown(KeyCode.E)) {
			to_Search.SetActive (false);

			found_Key.SetActive (true);
			
			engaged = true;
			
			print ("found key");

			found_the_Key = true;
		}
		
		if (withinRadius_crate == true && Input.GetMouseButtonDown (1)) {
			to_Search.SetActive (false);

			found_Key.SetActive (true);

			
			//print ("should be told how to search");
			
			//searching = true;
		}
		
		
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Good_Crate")
			withinRadius_crate = true;
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Good_Crate")
			withinRadius_crate = false;
	}
}
