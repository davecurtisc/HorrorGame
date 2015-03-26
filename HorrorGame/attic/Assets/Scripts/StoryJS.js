import UnityEngine.UI;

#pragma strict

var storyCount = 0;
var words : Text;
var outputTips = ["Move the mouse to look around", "Use the knife to cut your bonds [E]", "Look around for a key to escape"];
var canvas : Canvas;

var motor : CharacterMotor;


function Start () {
	//canvas = GetComponent.<Canvas>();
	//canvas.enabled = true;
	words.text = outputTips[storyCount];
}

function Update () {
		

	if (storyCount == 0 && Input.GetAxis ("Mouse X") < 0) 
		{
			storyCount = 1;
			//yield WaitForSeconds (1);
			words.text = outputTips[storyCount];

		}
	if (storyCount == 1 && Input.GetMouseButtonDown(0))
	{
		storyCount = 2;
		words.text = outputTips[storyCount];
		motor.enabled = true;
	}
}



