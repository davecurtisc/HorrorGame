using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerEnter () {
		Application.LoadLevel (6);
	}
}
