using UnityEngine;
using System.Collections;

public class Paper2 : MonoBehaviour {

	public bool withinRadius_Paper2;

	public GameObject paper2;

	// Use this for initialization
	void Start () {
		paper2.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (withinRadius_Paper2 == true && Input.GetMouseButtonDown (0)) {
			paper2.SetActive (true);
			
			print ("should be reading");
		}

		if(withinRadius_Paper2 == false && Input.GetMouseButtonDown(0)){
			paper2.SetActive(false);

		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_Paper2 = true;
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius_Paper2 = false;
	}
}
