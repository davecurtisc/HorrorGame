using UnityEngine;
using System.Collections;

public class sceneChanger : MonoBehaviour {

	public static int counter = 0;
	// Update is called once per frame
	void Update () {
		if (counter == 3) {
			Application.LoadLevel("Start_Screen");
		}
	}
}
