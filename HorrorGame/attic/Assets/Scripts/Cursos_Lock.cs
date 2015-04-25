using UnityEngine;
using System.Collections;

public class Cursos_Lock : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

			if (Input.GetKey(KeyCode.Escape))
				Screen.lockCursor = false;
			else
				Screen.lockCursor = true;
		}
	}

