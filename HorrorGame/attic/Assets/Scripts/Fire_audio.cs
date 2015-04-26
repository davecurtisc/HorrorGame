using UnityEngine;
using System.Collections;

public class Fire_audio : MonoBehaviour {

	public static bool got_Key;

	public static bool audiofire;

	public GameObject audio;

	// Use this for initialization
	void Start () {

		audio.SetActive (true);
	
	}
	
	// Update is called once per frame
	void Update () {

		audiofire = laser_Levels.audio_on;

		if (audiofire == false) {
			audio.SetActive(false);

		}
	
	}
}
