using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Crosshair_match : MonoBehaviour {

	public GameObject cursor;

	// Use this for initialization
	void Start () {
	
		gameObject.transform.position = Camera.main.ScreenToViewportPoint(Input.mousePosition);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
