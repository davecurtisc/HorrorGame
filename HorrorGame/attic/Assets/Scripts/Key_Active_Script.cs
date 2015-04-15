using UnityEngine;
using System.Collections;

public class Key_Active_Script : MonoBehaviour {

	public GameObject key;
	public GameObject BridgeTile1, BridgeTile2, BridgeTile3, BridgeTile4, BridgeTile5, BridgeTile6, BridgeTile7,
	BridgeTile8, BridgeTile9;
	public GameObject leave;

	void OnTriggerEnter () {
		key.SetActive (false);
		BridgeTile1.SetActive (true);
		BridgeTile2.SetActive (true);
		BridgeTile3.SetActive (true);
		BridgeTile4.SetActive (true);
		BridgeTile5.SetActive (true);
		BridgeTile6.SetActive (true);
		BridgeTile7.SetActive (true);
		BridgeTile8.SetActive (true);
		BridgeTile9.SetActive (true);
		leave.SetActive (true);
	}
}
