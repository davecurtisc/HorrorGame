using UnityEngine;
using System.Collections;

public class Lights_off : MonoBehaviour {

	public GameObject candle;

	private bool withinRadius;

	public int Counter = 0;

	//GameObject pickup_check = GameObject.Find("Candle 4");
	//Pickup_Candle bScript = pickup_check.GetComponent<Pickup_Candle>();
	//Pickup_Candle.pickedup();

	//public static bool picked_up;

	//private bool withinRadius;

	private Light Candle_Lights;
	float timeLeft = 2.0f;

	// Use this for initialization
	void Start () {
		Candle_Lights = GetComponent<Light>();

	}
	
	// Update is called once per frame
	void Update () 
	{
		//picked_up = Pickup_Candle.pickedup;

		timeLeft -= Time.deltaTime;
		if (timeLeft < 0 && Counter == 0) {
			//turn off lights
			Candle_Lights.enabled = false;
			print("The light should be off");
			Counter = 1;
		}
		if (Input.GetMouseButtonDown (0) && Counter == 1 && withinRadius == true) 
			
		{
			//turn on lights
			print("The light should be back on");
			Candle_Lights.enabled = true;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius = true;
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius = false;
	}
}
