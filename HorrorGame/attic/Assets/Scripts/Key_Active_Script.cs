using UnityEngine;
using System.Collections;

public class Key_Active_Script : MonoBehaviour {

	public GameObject key;
	public GameObject BridgeTile1, BridgeTile2, BridgeTile3, BridgeTile4, BridgeTile5, BridgeTile6, BridgeTile7,
	BridgeTile8, BridgeTile9;
	public GameObject leave;

	public bool within_Radius;

	public static bool has_Key;

	public GameObject key_Gui;

	public GameObject the_Key;

	void Start(){
	
		within_Radius = false;

		has_Key = false;

		key_Gui.SetActive (false);

		the_Key.SetActive (true);
	}

	void Update(){

		if (within_Radius == true && Input.GetMouseButtonDown (0)) {
		
			has_Key = true;

			key_Gui.SetActive(true);

			the_Key.SetActive(false);

		}
	}

	void OnTriggerEnter () {
		//key.SetActive (false);
		BridgeTile1.SetActive (true);
		BridgeTile2.SetActive (true);
		BridgeTile3.SetActive (true);
		BridgeTile4.SetActive (true);
		BridgeTile5.SetActive (true);
		BridgeTile6.SetActive (true);
		BridgeTile7.SetActive (true);
		BridgeTile8.SetActive (true);
		BridgeTile9.SetActive (true);
		//leave.SetActive (true);

		within_Radius = true;
	}
}
