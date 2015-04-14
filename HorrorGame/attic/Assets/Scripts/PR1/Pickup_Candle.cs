using UnityEngine;
using System.Collections;

public class Pickup_Candle : MonoBehaviour {
	
	private bool withinRadius;

	public GameObject candle;

	public GameObject newcandle;

	public static bool pickedup = false;
	
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)
		   && withinRadius && pickedup == false)
		{
			//Destroy(gameObject);
			newcandle.SetActive(true);
			candle.SetActive(false);

			//gameObject.GetComponent<ParticleSystem>().enableEmission = false;
			pickedup = true;
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


