using UnityEngine;
using System.Collections;

public class Candle_off : MonoBehaviour {

	private bool withinRadius;

	public int Counter = 0;

	float timeLeft = 2.0f;

	private static bool candle_req;

	// Use this for initialization
	void Start () {
		//Candles = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {

		candle_req = Pickup_Candle.pickedup;

		timeLeft -= Time.deltaTime;
		if(timeLeft < 0 && Counter == 0)
		{
			//turn off lights
			//Candles.enabled = false;
			gameObject.GetComponent<ParticleSystem>().enableEmission = false;
			Counter = 1;
			print("The particle should be off");

		}
		if (candle_req == true && Input.GetMouseButtonDown (0) && Counter == 1 && withinRadius == true) 
			
		{
			//turn on lights
			print("The particle should be back on");
			gameObject.GetComponent<ParticleSystem>().enableEmission = true;
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

