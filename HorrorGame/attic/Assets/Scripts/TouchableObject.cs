using UnityEngine;
using System.Collections;

public class TouchableObject : MonoBehaviour
{
	public GameObject displayImage;

	public static bool read_Paper = false;
	
	void OnTouch()
	{
		displayImage.SetActiveRecursively(true);

		print("touching");

		read_Paper = true;
	}
	
	void UnTouch()
	{
		displayImage.SetActiveRecursively(false);
	}
}