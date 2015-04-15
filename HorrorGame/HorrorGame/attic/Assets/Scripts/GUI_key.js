﻿import UnityEngine.UI;

var toggleGUI : boolean;
var keycount = 0;
var someText: Text;

 function Start() { 
 toggleGUI = false;
 
 GetComponent(UI.Text);
 someText = GetComponent.<Text>();
 
 }
 
  function OnTriggerEnter (other : Collider) {
  toggleGUI = true;
  }
  
  function OnTriggerExit (other : Collider) {
  toggleGUI = false;
  }
  
  function OnGUI () {

  
  	if (toggleGUI == true)
  		GUI.Label (Rect (10, 300, 100, 20), "Click to pickup the key");
  	
  	if(Input.GetMouseButtonDown(0)){
  		Destroy(gameObject);
  		//GUI.Label (Rect (10, 300, 100, 20), "You have a KEY");
 		Debug.Log ("Key was picked up");
 		keycount = 1;
 		someText.text = "Hello and junk";
  		}
  }

