var lookStyle : GUIStyle;

var ShowMouseGUI : boolean;
var ShowPickupGUI : boolean;

function Start () {
ShowMouseGUI = true;
ShowPickupGUI = false;
}
/*
function OnGUI () {
	if (ShowMouseGUI == true){
		GUI.Label (Rect (500,400,300,300),"Move the mouse to looks around", lookStyle);
		}
		if(Input.GetAxis("Mouse X")<0){
     	ShowMouseGUI = false;
		
	if (ShowMouseGUI == false){
		GUI.enabled = false;
	}

}

}

function UpdateGUI () {
	if(ShowMouseGUI == false)
	{
		ShowPickupGUI = true;
	}
		
	if(ShowPickupGUI == true)
	{
		GUI.Label (Rect (500,400,300,300),"Pickup an object and cut yourself free [E]", lookStyle);
		GUI.enabled = true;
	}

}
*/