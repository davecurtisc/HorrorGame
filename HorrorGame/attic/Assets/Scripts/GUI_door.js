var toggleGUI : boolean;
//var keycount = 0;

 function Start() { 
 toggleGUI = false;
 }
 
  function OnTriggerEnter (other : Collider) {
  toggleGUI = true;
  }
  
  function OnTriggerExit (other : Collider) {
  toggleGUI = false;
  }
  
  function OnGUI () {
  	if (toggleGUI == true){
  		GUI.Label (Rect (10, 300, 100, 20), "Press E to Enter");
  		}
  		/*
  else if (toggleGUI == true && keycount ==0){
  		GUI.Label (Rect (10, 300, 100, 20), "locked");
  		Debug.Log("Locked");
  }
  */
  }