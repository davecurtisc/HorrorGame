using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tile_text : MonoBehaviour {

	public GameObject goal1;
	public GameObject goal2;

	public static bool key_On;

	// Use this for initialization
	void Start () {

		goal1.SetActive (true);
		goal2.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		key_On = Key_Active_Script.has_Key;

		if (key_On == true) {
		
			Text text = goal1.GetComponent<Text> (); //get the text component in the gameobject you assigned
			text.color = Color.green;

			goal2.SetActive(true);

		}
	
	}
}
