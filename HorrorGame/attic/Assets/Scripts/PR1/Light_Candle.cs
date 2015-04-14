using UnityEngine;
using System.Collections;

public class Light_Candle : MonoBehaviour 
{
	
	private bool withinRadius;
	public GameObject candle;

	//private static GameObject candle;

	void Awake()
	{
		// find game object with name or tag
	}

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0)
		   && withinRadius)
		{
			if(candle.activeInHierarchy)
			{
				//GetComponent<Light>().
			}
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


