using UnityEngine;
using System.Collections;

public class SphereActive : MonoBehaviour {
	
	public bool withinRadius_Statue1 = false;
	public bool withinRadius_Statue2 = false;
	public bool withinRadius_Statue3 = false;
	public bool withinRadius_door_end = false;

	public GameObject orb1;
	public GameObject orb2;
	public GameObject orb3;

	public GameObject Sphere_obj1;

	public GameObject Player_Sphere1;
	public GameObject Player_Sphere2;
	public GameObject Player_Sphere3;

	public static bool has_Orb1;
	public static bool has_Orb2;
	public static bool has_Orb3;

	public static int orb_Counter;

	//fire
	public GameObject fire1;
	public GameObject fire2;
	public GameObject fire3;

	public GameObject fire4;
	public GameObject door_end;

	public bool canExit;

	public GameObject door_Locked;

	public AudioClip fire;



	// Use this for initialization
	void Start () {
		orb1.SetActive (false);
		orb2.SetActive (false);
		orb3.SetActive (false);

		has_Orb1 = false;
		has_Orb2 = false;
		has_Orb3 = false;

		fire1.SetActive (false);
		fire2.SetActive (false);
		fire3.SetActive (false);

		orb_Counter = 0;

		door_end.SetActive (false);
		fire4.SetActive (false);

		canExit = false;

		door_Locked.SetActive (false);


	}
	
	// Update is called once per frame
	void Update () {


		print(orb_Counter);

		has_Orb1 = sphere1.pickedup_Orb1;
		has_Orb2 = sphere1.pickedup_Orb2;
		has_Orb3 = sphere1.pickedup_Orb3;

		if (withinRadius_Statue1 && Input.GetMouseButtonDown(0) && has_Orb1 == true) 
		{
				orb1.SetActive(true);
				orb_Counter++;
				Player_Sphere1.SetActive(false);

			fire1.SetActive(true);

			if (orb_Counter >= 3) {
				fire4.SetActive(true);
				//door_end.SetActive(true);
				//GetComponent<AudioSource>().Play("fire");

				canExit = true;

				StartCoroutine(fire4_leaves());

				StartCoroutine(door_Enters());
			}
		}


		if (withinRadius_Statue2 && Input.GetMouseButtonDown(0) && has_Orb2 == true) 
		{
			if(Input.GetMouseButtonDown(0))
			{
				orb2.SetActive(true);
				orb_Counter++;
				//change later
				Player_Sphere2.SetActive(false);

				fire2.SetActive(true);

				if (orb_Counter >= 3) {
					fire4.SetActive(true);
					//door_end.SetActive(true);
					//GetComponent<AudioSource>().Play("fire");

					canExit = true;

					StartCoroutine(fire4_leaves());

					StartCoroutine(door_Enters());
				}


			}
		}

		if (withinRadius_Statue3 && Input.GetMouseButtonDown(0) && has_Orb3 == true) 
		{
			if(Input.GetMouseButtonDown(0))
			{
				orb3.SetActive(true);
				orb_Counter++;
				//change later
				Player_Sphere3.SetActive(false);

				fire3.SetActive(true);

				if (orb_Counter >= 3) {
					fire4.SetActive(true);
					//door_end.SetActive(true);
					//GetComponent<AudioSource>().Play("fire");


					canExit = true;

					StartCoroutine(fire4_leaves());

					StartCoroutine(door_Enters());
				}
			}
		}

		if (canExit == true && withinRadius_door_end && Input.GetKeyDown (KeyCode.E)) {
		
			Application.LoadLevel("GameComplete");
		}

		if (canExit == false && withinRadius_door_end && Input.GetKeyDown (KeyCode.E)) {
		
			door_Locked.SetActive(true);

			StartCoroutine(locked_leaves());
		}


	}

	IEnumerator locked_leaves()
	{
		
		yield return new WaitForSeconds(2);
		
		door_Locked.SetActive(false);
		//Do Function here...
	}

	IEnumerator fire4_leaves()
	{
		
		yield return new WaitForSeconds(7);
		
		fire4.SetActive(false);
		//Do Function here...
	}

	IEnumerator door_Enters()
	{
		
		yield return new WaitForSeconds(2);
		
		door_end.SetActive(true);


		//Do Function here...
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Statue1") 
		{
			withinRadius_Statue1 = true;
		}

		if (other.gameObject.tag == "Door_end") 
		{
			withinRadius_door_end = true;
		}

		if (other.gameObject.tag == "Statue2") 
		{
			withinRadius_Statue2 = true;
		}

		if (other.gameObject.tag == "Statue3") 
		{
			withinRadius_Statue3 = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Statue1") 
		{
			withinRadius_Statue1 = false;
		}
		
		if (other.gameObject.tag == "Statue2") 
		{
			withinRadius_Statue2 = false;
		}
		
		if (other.gameObject.tag == "Statue3") 
		{
			withinRadius_Statue3 = false;
		}

		if (other.gameObject.tag == "Door_end") 
		{
			withinRadius_door_end = false;
		}
	}
}
