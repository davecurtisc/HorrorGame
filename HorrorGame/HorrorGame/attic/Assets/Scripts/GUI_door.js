var toggleGUI : boolean;
// CHANGE THIS SCRIPT TO C# TO BE ABLE TO READ BACK THE KEYCOUNT VARIABLE FROM 'KeyCount'.cs

//var keycount = 0;
//private static kcount = KeyCount.keyCount;
//kcount = KeyCount.keyCount;

 function Start() { 
 toggleGUI = false;
 }
 
 function Update() {
 //kcount = KeyCount.keyCount;
 
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
  	else{
  		GUI.Label (Rect (10, 300, 100, 20), "Locked");
  	
  	}
  		/*
  else if (toggleGUI == true && keycount ==0){
  		GUI.Label (Rect (10, 300, 100, 20), "locked");
  		Debug.Log("Locked");
  }
  */
  }