using UnityEngine;
using System.Collections;

public class TryTouch : MonoBehaviour
{
	
	GameObject currentlyTouched;
	
	void Touch()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		
		if (Physics.Raycast (ray, out hit, 10f))
		{
			
			if(hit.collider.gameObject.tag == "Touchable") // Did it hit the paper?
			{
				// Show the paper
				hit.collider.gameObject.SendMessage("OnTouch");
				currentlyTouched = hit.collider.gameObject;
			}
		}
	}
	
	void Update()
	{
		if(Input.GetMouseButtonDown(0)) // If the player clicks with the left mouse button
		{
			if(currentlyTouched == null)
			{
				Touch(); // then execute Touch()
			}
			else
			{
				currentlyTouched.SendMessage("UnTouch");
				currentlyTouched = null;
			} 
		}
	}
}