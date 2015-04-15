using UnityEngine;
using System.Collections;

public class Leave_Tile_Puzzle : MonoBehaviour {

	void OnTriggerEnter(){
		Application.LoadLevel (1);
	}
}
