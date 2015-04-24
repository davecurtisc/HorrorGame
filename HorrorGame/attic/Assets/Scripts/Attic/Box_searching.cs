using UnityEngine;
using System.Collections;

public class Box_searching : MonoBehaviour {

	private bool withinRadius_crate;

	public GameObject to_Search;
	public GameObject found_Nothing;

	public bool searching = false;

	public bool engaged = false;

	// Use this for initialization
	void Start () {

		to_Search.SetActive (false);
		found_Nothing.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		//told how to search if touching
		if (withinRadius_crate == true && engaged == false) {

			to_Search.SetActive (true);
			
			print ("should be told how to search");

			searching = true;

		}

		//if close and E is pressed
		if (withinRadius_crate == true && Input.GetKeyDown(KeyCode.E)) {

			to_Search.SetActive (false);
			found_Nothing.SetActive (true);

			engaged = true;
			
			print ("found nothing");

			// start timer for 'Found nothing' to leave screen
			StartCoroutine(nothing_leaves());
		}

		/*
		else if (withinRadius_crate == false) {

			to_Search.SetActive (false);
			found_Nothing.SetActive (false);
		}
*/
	
	
	}

	IEnumerator nothing_leaves()
	{
		
		yield return new WaitForSeconds(1);
		
		found_Nothing.SetActive(false);
		//Do Function here...
	}


	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_crate = true;
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_crate = false;
			to_Search.SetActive(false);
	}
}
