using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Goal_Room1 : MonoBehaviour {

	public GameObject goal1;
	public GameObject goal2;
	public GameObject goal3;

	public static bool pickedcandle;

	public static bool canOpen;

	// Use this for initialization
	void Start () {

		goal1.SetActive (true);
		goal2.SetActive (false);
		goal3.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		pickedcandle = Pickup_Candle.pickedup;

		canOpen = Candle_off.can_open_door;

		if (pickedcandle == true) {
		
			goal2.SetActive(true);
		}

		if (canOpen == true) {
		
			Text text = goal2.GetComponent<Text> (); //get the text component in the gameobject you assigned
			text.color = Color.green;

			goal3.SetActive(true);
		}

		}
	
}

