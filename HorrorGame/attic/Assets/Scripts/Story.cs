using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Story : MonoBehaviour {

	public Text output;
	
	private int storyCount = 0;

	void Awake()
	{

	}

	private string[] outputTips = 
	{
		"Move the mouse to look around",
		"Use the knife to cut your bonds [E]",
		"Look around for a key to escape"
	};

	// Use this for initialization
	void Start () 
	{
		output.text = outputTips[storyCount];
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (storyCount == 0 
		    && Input.GetAxis ("Mouse X") < 0) 
		{
			StartCoroutine("Wait", 1);
			storyCount = 1;
		}

		if (storyCount == 1 
		    && Input.GetMouseButtonDown(0)) //if player is promted to pickup the knife and clicks
		{
			//Storycount = 2;
			Application.LoadLevel("Attic");
		}
	}


	private IEnumerator Wait(int value) // 2 second delay on the mouse press
	{
		yield return new WaitForSeconds(1.0f);
		output.text = outputTips [value];
	}
}

