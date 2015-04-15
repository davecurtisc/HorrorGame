var toggleGUI_drawer : boolean;
//var keycount = 0;

 function Start() { 
 toggleGUI_drawer = false;
 }
 
  function OnTriggerEnter (other : Collider) {
  toggleGUI_drawer = true;
  }
  
  function OnTriggerExit (other : Collider) {
  toggleGUI_drawer = false;
  }
  
  function OnGUI () {
  	if (toggleGUI_drawer == true){
  		GUI.Label (Rect (10, 300, 100, 20), "E to Search");
  		}
  	}