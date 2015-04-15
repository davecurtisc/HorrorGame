using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scene_Fade_in_out : MonoBehaviour {

	public float fadeSpeed = 1.5f;
	private bool sceneStarting = true;
	public bool isAttic = false;

	void Awake()
	{
		//GetComponent<Image>().pixelInset = new Rect (0f, 0f, Screen.width, Screen.height);
	}

	void Update()
	{
		if (sceneStarting)
			StartScene ();
	}

	void FadeToClear()
	{
		GetComponent<Image>().color = Color.Lerp (GetComponent<Image>().color, Color.clear, fadeSpeed * Time.deltaTime);
	}

	void FadeToBlack()
	{
		GetComponent<Image>().color = Color.Lerp (GetComponent<Image>().color, Color.black, fadeSpeed * Time.deltaTime);
	}

	void StartScene()
	{
		FadeToClear ();

		if (GetComponent<Image>().color.a <= 0.05f) 
		{
			GetComponent<Image>().color = Color.clear;
			GetComponent<Image>().enabled = false;
			sceneStarting = false;
		}
	}

	public void EndScene()
	{
		GetComponent<Image>().enabled = true;
		FadeToBlack ();

		if (GetComponent<Image> ().color.a >= 0.95f && isAttic == false) {
			Application.LoadLevel ("main_menu");
		} else
			Application.LoadLevel ("Attic");
	}

}
