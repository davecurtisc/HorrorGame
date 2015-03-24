using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeyCount : MonoBehaviour {

	public Text output;
	
	private bool withinRadius;
	private static int keyCount = 0;
	
	void Awake()
	{
		if(output == null)
			Debug.LogError("No key string output");
	}

	void Update()
	{
		if(Input.GetMouseButtonDown(0)
		   && withinRadius)
		{
			keyCount++;
			output.text = "Key Count: " + keyCount;
			Destroy(gameObject);
		}
	}

	/* Are you within the trigger zone?
	 * Are you player?
	 * Do you have any keys? is key > 0
	 * keyCount--
	 * Open the door, load the scene
	 */

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius = true;
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
			withinRadius = false;
	}
}
