using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Door_PR2 : MonoBehaviour {
	
	private bool withinRadius_D2;
	public bool canopen = false;

	private static bool keyreturn;

	public GameObject lock_gui;
	
	//public Text output;
	
	// Use this for initialization
	void Start () {

		lock_gui.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {

		keyreturn = puzzle2Key.pickedup;
		print (puzzle2Key.pickedup);
		
		if (withinRadius_D2 == true) {
			//output.text = "Press E to enter";
			canopen = true;
		}
		
		if (canopen == true && Input.GetKeyDown (KeyCode.E) && keyreturn == true) {
			Application.LoadLevel ("Hallway3"); 

			print("Hallway 3 should load");
		}

		if (canopen == true && Input.GetKeyDown (KeyCode.E) && keyreturn == false) {
			print("You need the key");

			lock_gui.SetActive(true);

			StartCoroutine(locked_leaves());
		}
		
	}

	IEnumerator locked_leaves()
	{
		
		yield return new WaitForSeconds(2);
		
		lock_gui.SetActive(false);
		//Do Function here...
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_D2 = true;
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_D2 = false;
	}
}
