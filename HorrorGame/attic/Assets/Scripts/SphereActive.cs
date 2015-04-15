using UnityEngine;
using System.Collections;

public class SphereActive : MonoBehaviour {
	
	public bool withinRadius = false;
	public bool Sphere = false;
	public Renderer rend;
	public GameObject target;


	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {


		if (withinRadius) 
		{
			if(Input.GetMouseButtonDown(0))
			{
				rend.enabled = true;
				withinRadius = false;
				turnOff();
				sceneChanger.counter++;
			}
		}
	}

	void turnOff(){
		target.SetActive(false);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			withinRadius = true;
		}
	}
}
