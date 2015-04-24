using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Goal_Attic : MonoBehaviour {

	public GameObject goal1;
	public GameObject goal2;
	public GameObject goal3;

	public static bool read_Return;
	public static bool key_Return;

	// Use this for initialization
	void Start () {
	
		//goal1.SetActive (true);
		//goal2.SetActive (true);
		goal3.SetActive (false);
		goal2.SetActive (true);

		//read_Return = TouchableObject.read_Paper;
	}
	
	// Update is called once per frame
	void Update () {

		read_Return = TouchableObject.read_Paper;
		key_Return = Box2.found_the_Key;

		if (read_Return == true) {

			print ("text should change");
			Text text = goal2.GetComponent<Text> (); //get the text component in the gameobject you assigned
			text.color = Color.green;
		}

		if (key_Return == true) {
		
			Text text = goal1.GetComponent<Text> (); //get the text component in the gameobject you assigned
			text.color = Color.green;

			//goal3.SetActive(true);

			StartCoroutine(leavemsg_enters());
		}
	

	}

	IEnumerator leavemsg_enters()
	{
		
		yield return new WaitForSeconds(1);
		
		goal3.SetActive(true);
		//Do Function here...
	}
}
