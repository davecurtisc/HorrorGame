using UnityEngine;
using System.Collections;

public class Candle_off : MonoBehaviour {

	float timeLeft = 2.0f;
	//private Light Candles;

	// Use this for initialization
	void Start () {
		//Candles = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0)
		{
			//turn off lights
			//Candles.enabled = false;
			gameObject.GetComponent<ParticleSystem>().enableEmission = false;

		}
	}
}
