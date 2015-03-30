using UnityEngine;
using System.Collections;

public class Lights_off : MonoBehaviour {

	private Light Candle_Lights;
	float timeLeft = 2.0f;

	// Use this for initialization
	void Start () {
		Candle_Lights = GetComponent<Light>();

	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0)
		{
			//turn off lights
			Candle_Lights.enabled = false;
	
			
		}
	}

}
