using UnityEngine;
using System.Collections;

public class TouchableObject : MonoBehaviour
{
	public GameObject displayImage;
	
	void OnTouch()
	{
		displayImage.SetActiveRecursively(true);

		print("touching");
	}
	
	void UnTouch()
	{
		displayImage.SetActiveRecursively(false);
	}
}