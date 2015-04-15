using UnityEngine;
using System.Collections;

public class Sphere3 : MonoBehaviour {

	private bool withinRadius;
	
	public GameObject mySphere;
	
	public GameObject newSphere;
	
	public static bool pickedup = false;
	
	// Use this for initialization
	void Start () {
		newSphere.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)
		   && withinRadius && pickedup == false)
		{
			Switch ();
			
			
		}
	}
	
	void Switch(){
		newSphere.SetActive(true);
		mySphere.SetActive(false);
		
		pickedup = true;
		
	}
	
	
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			withinRadius = true;
			
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			withinRadius = false;
			
		}
	}
}
