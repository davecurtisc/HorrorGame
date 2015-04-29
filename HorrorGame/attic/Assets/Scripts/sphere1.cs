using UnityEngine;
using System.Collections;

public class sphere1 : MonoBehaviour {

	private bool withinRadius_Orb1;
	private bool withinRadius_Orb2;
	private bool withinRadius_Orb3;
	
	public GameObject Sphere_obj1;
	public GameObject Sphere_obj2;
	public GameObject Sphere_obj3;
	
	public GameObject Player_Sphere1;
	public GameObject Player_Sphere2;
	public GameObject Player_Sphere3;
	
	public static bool pickedup_Orb1 = false;
	public static bool pickedup_Orb2 = false;
	public static bool pickedup_Orb3 = false;
	
	// Use this for initialization
	void Start () {
		Player_Sphere1.SetActive (false);

		Sphere_obj1.SetActive (true);
		Sphere_obj2.SetActive (true);
		Sphere_obj3.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0) && withinRadius_Orb1 && pickedup_Orb1 == false)
		{

			Player_Sphere1.SetActive(true);
			Sphere_obj1.SetActive(false);
			
			pickedup_Orb1 = true;
			
		}

		if(Input.GetMouseButtonDown(0) && withinRadius_Orb2 && pickedup_Orb2 == false)
		{
			//change later
			Player_Sphere2.SetActive(true);
			Sphere_obj2.SetActive(false);
			
			pickedup_Orb2 = true;
			
		}

		if(Input.GetMouseButtonDown(0) && withinRadius_Orb3 && pickedup_Orb3 == false)
		{
			//change later
			Player_Sphere3.SetActive(true);
			Sphere_obj3.SetActive(false);
			
			pickedup_Orb3 = true;
			
		}
	}
	
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Sphere_Obj1") {
			withinRadius_Orb1 = true;
		}

		if (other.gameObject.tag == "Sphere_Obj2") {
			withinRadius_Orb2 = true;
		}

		if (other.gameObject.tag == "Sphere_Obj3") {
			withinRadius_Orb3 = true;
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Sphere_Obj1") {
			withinRadius_Orb1 = false;
		}

		if (other.gameObject.tag == "Sphere_Obj2") {
			withinRadius_Orb3 = false;
		}

		if (other.gameObject.tag == "Sphere_Obj3") {
			withinRadius_Orb3 = false;
		}
	}
}
