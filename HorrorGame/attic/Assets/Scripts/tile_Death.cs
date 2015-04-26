using UnityEngine;
using System.Collections;

public class tile_Death : MonoBehaviour {

	public bool playerDied;

	public GameObject Player;

	// Use this for initialization
	void Start () {

		playerDied = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Player.transform.position.y < -4.5) {
			print("should be dead");

			Application.LoadLevel("Tile_Puzzle");
		}
	
	}
}
