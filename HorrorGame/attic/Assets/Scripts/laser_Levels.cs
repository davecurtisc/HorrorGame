using UnityEngine;
using System.Collections;

public class laser_Levels : MonoBehaviour {

	public GameObject Lever1;
	public GameObject Lever2;
	public GameObject Lever3;

	public GameObject Rod1;
	public GameObject Rod2;
	public GameObject Rod3;

	public bool CanPressLever1 = false;
	public bool CanPressLever2 = false;
	public bool CanPressLever3 = false;


	// Use this for initialization
	void Start () {
		//Rod1 = GameObject.Find("Rod1");
		//Lever1 = GameObject.Find("Lever1");
	}
	
	// Update is called once per frame
	void Update () {
		if(CanPressLever1 == true && Input.GetMouseButtonDown(0)){
			Destroy(Rod1);
			print("Rod1 should be destroyed");

		}
		if(CanPressLever2 == true && Input.GetMouseButtonDown(0)){
			Destroy(Rod2);
			print("Rod2 should be destroyed");
			
		}
		if(CanPressLever3 == true && Input.GetMouseButtonDown(0)){
			Destroy(Rod3);
			print("Rod3 should be destroyed");
			
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Lever1"){  
			//Destroy (Rod1);
			print("Touching a lever");
			CanPressLever1 = true;

	}
		if (other.gameObject.tag == "Lever2"){
			print("Touching lever2");
			CanPressLever2 = true;

		}
		if (other.gameObject.tag == "Lever3"){
			print("Touching a lever3");
			CanPressLever3 = true;
			
		}
}
}
