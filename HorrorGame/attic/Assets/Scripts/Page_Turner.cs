using UnityEngine;
using System.Collections;

public class Page_Turner : MonoBehaviour {

	private bool withinRadius_book;

	public GameObject page1;
	public GameObject page2;
	public GameObject page3;
	

	// Use this for initialization
	void Start () {
	
		page1.SetActive (false);
		page2.SetActive (false);
		page3.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (withinRadius_book == true && Input.GetMouseButtonDown (0)) {
			page1.SetActive (true);

			print ("should be reading");
		}	

		if(withinRadius_book == true && Input.GetKeyDown(KeyCode.N)){
			page1.SetActive(false);
			page2.SetActive(true);

			print("should turn page");
		}

		if (withinRadius_book == true && Input.GetKeyDown (KeyCode.M)) {
			page2.SetActive(false);
			page3.SetActive(true);
		}


			if(Input.GetMouseButtonDown(1)){
				page1.SetActive(false);
				page2.SetActive(false);
				page3.SetActive(false);
			}
		}




	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_book = true;
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_book = false;
	}
}

