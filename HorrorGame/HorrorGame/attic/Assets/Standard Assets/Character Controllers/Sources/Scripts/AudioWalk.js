#pragma strict

var AudioFile : AudioClip;

function Start () {

}

function Update () {

     var isMoving = Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d");
 
     // which translates to: "If I'm holding 'w', 'a', 's' or 'd' -> I'm moving"
 
     if(isMoving)
     {
        if (!GetComponent.<AudioSource>().isPlaying)
        {
           GetComponent.<AudioSource>().Play();
        }
     }
     else GetComponent.<AudioSource>().Stop();
 }
 

