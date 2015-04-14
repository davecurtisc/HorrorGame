using UnityEngine;
using System.Collections;

public class Candle : MonoBehaviour 
{
	protected bool letPlay = true;
	
	public void Update()
	{
		if(Input.GetKeyDown(KeyCode.E))
		{
			letPlay = !letPlay;
		}
		
		if(letPlay)
		{
			if(!gameObject.GetComponent<ParticleSystem>().isPlaying)
			{
				gameObject.GetComponent<ParticleSystem>().Play();
				print("should be on");
			}
		}else{
			if(gameObject.GetComponent<ParticleSystem>().isPlaying)
			{
				gameObject.GetComponent<ParticleSystem>().Stop();
			}
		}
	}
}