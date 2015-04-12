using UnityEngine;
using System.Collections;

public class laser_Levels : MonoBehaviour {

	//levers
	public GameObject Lever1;
	public GameObject Lever2;
	public GameObject Lever3;
	public GameObject Lever4;
	public GameObject Lever5;
	public GameObject Lever6;
	public GameObject Lever7;
	public GameObject Lever8;
	public GameObject Lever9;
	public GameObject Lever10;
	public GameObject Lever11;

	//lever pulls
	public GameObject Puller1;
	public GameObject Puller2;
	public GameObject Puller3;
	public GameObject Puller4;
	public GameObject Puller5;
	public GameObject Puller6;
	public GameObject Puller7;
	public GameObject Puller8;
	public GameObject Puller9;
	public GameObject Puller10;
	public GameObject Puller11;

	//rods for setactive
	public GameObject Rod1;
	public GameObject Rod2;
	public GameObject Rod3;
	public GameObject Rod4;
	public GameObject Rod5;
	public GameObject Rod6;
	public GameObject Rod7;
	public GameObject Rod8;
	public GameObject Rod9;
	public GameObject Rod10;
	public GameObject Rod11;
	public GameObject Rod12;
	public GameObject Rod13;
	public GameObject Rod14;
	public GameObject Rod15;
	public GameObject Rod16;
	public GameObject Rod17;
	public GameObject Rod18;
	public GameObject Rod19;
	
	//bools for collision
	public bool CanPressLever1 = false;
	public bool CanPressLever2 = false;
	public bool CanPressLever3 = false;
	public bool CanPressLever4 = false;
	public bool CanPressLever5 = false;
	public bool CanPressLever6 = false;
	public bool CanPressLever7 = false;
	public bool CanPressLever8 = false;
	public bool CanPressLever9 = false;
	public bool CanPressLever10 = false;
	public bool CanPressLever11 = false;
	
	//bools for pull proofing
	public bool Rod1_on = true;
	public bool Rod2_on = true;
	public bool Rod3_on = true;
	public bool Rod4_on = false;
	public bool Rod5_on = true;
	public bool Rod6_on = true;
	public bool Rod7_on = true;
	public bool Rod8_on = true;
	public bool Rod9_on = true;
	public bool Rod10_on = true;
	public bool Rod11_on = true;
	public bool Rod12_on = true;
	public bool Rod13_on = true;
	public bool Rod14_on = true;
	public bool Rod15_on = true;
	public bool Rod16_on = true;
	public bool Rod17_on = true;
	public bool Rod18_on = true;
	public bool Rod19_on = true;


	public bool Puller1_down = false;
	public bool Puller2_down = false;
	public bool Puller3_down = false;
	public bool Puller4_down = false;
	public bool Puller5_down = false;
	public bool Puller6_down = false;
	public bool Puller7_down = false;
	public bool Puller8_down = false;
	public bool Puller9_down = false;
	public bool Puller10_down = false;

	public GameObject fire1;
	public GameObject fire2;
	public GameObject fire3;
	public GameObject fire4;
	public GameObject fire5;
	public GameObject fire6;
	public GameObject fire7;

	public GameObject cage;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//If touching lever and click mouse then setactive or !setactive rods

		if (CanPressLever1 == true && Input.GetMouseButtonDown (0)) {
			Rod1_on = !Rod1_on;
			Rod1.SetActive(Rod1_on);
			print ("Rod1 should be toggled");

			//lever pull
			Puller1.transform.eulerAngles = new Vector3(3,90,315);
			Puller1_down = true;


			fire1.SetActive(false);

		}
	
		if (CanPressLever2 == true && Input.GetMouseButtonDown (0)) {
			Rod2_on = !Rod2_on;
			Rod2.SetActive(Rod2_on);
			print ("Rod2 should be toggled");

			//lever pull
			Puller2.transform.eulerAngles = new Vector3(39,176,1);
			Puller2_down = true;

			fire2.SetActive(false);
			
		}
		if (CanPressLever3 == true && Input.GetMouseButtonDown (0)) {
			Rod3_on = !Rod3_on;
			Rod3.SetActive(Rod3_on);
			print ("Puller3 should be toggled");

			Puller3.transform.eulerAngles = new Vector3(66,-182,1);
			Puller3_down = true;

			fire3.SetActive(false);
			
		}

		if (CanPressLever4 == true && Input.GetMouseButtonDown(0)) {
			//Rod4.SetActive (true);
			print ("Puller4 should be toggled");
			//Rod4_on = !Rod4_on;
			//Rod4.SetActive(Rod4_on);

			Puller4.transform.eulerAngles = new Vector3(50,180,3);
			Puller4_down = true;
			
			fire4.SetActive(false);

		}

		if (CanPressLever5 == true && Input.GetMouseButtonDown (0)) {
			Rod1_on = !Rod1_on;
			Rod1.SetActive(Rod1_on);
			print ("Rod1 should be toggled");

			Puller5.transform.eulerAngles = new Vector3(-52,175,3);
			Puller5_down = true;
			
			fire1.SetActive(true);

			}

		if (CanPressLever6 == true && Input.GetMouseButtonDown (0)) {
			Rod5_on = !Rod5_on;
			Rod5.SetActive(Rod5_on);
			print ("Rod5 should be toggled");

			Puller6.transform.eulerAngles = new Vector3(305,175,3);
			Puller6_down = true;
			
			fire5.SetActive(false);
			
		}

		if (CanPressLever7 == true && Input.GetMouseButtonDown (0)) {
			Rod4_on = !Rod4_on;
			Rod4.SetActive(Rod4_on);
			print ("Rod4 should be toggled");

			Puller7.transform.eulerAngles = new Vector3(48,179,3);
			Puller7_down = true;
			
			fire4.SetActive(true);
			
		}

		if (CanPressLever8 == true && Input.GetMouseButtonDown (0)) {
			Rod6_on = !Rod6_on;
			Rod6.SetActive(Rod6_on);
			print ("Rod6 should be toggled");

			Puller8.transform.eulerAngles = new Vector3(50,-179,3);
			Puller8_down = true;
			
			fire6.SetActive(false);
			
		}

		if (CanPressLever9 == true && Input.GetMouseButtonDown (0)) {
			Rod1_on = !Rod1_on;
			Rod1.SetActive(Rod1_on);
			print ("Rod6 should be toggled");

			Puller9.transform.eulerAngles = new Vector3(57,-178,3);
			Puller9_down = true;
			
			fire1.SetActive(true);
			
		}

		if (CanPressLever10 == true && Input.GetMouseButtonDown (0)) {
			Rod7_on = !Rod7_on;
			Rod7.SetActive(Rod7_on);
			print ("Rod7 should be toggled");

			Puller10.transform.eulerAngles = new Vector3(2,-92,-66);
			Puller10_down = true;
			
			fire7.SetActive(false);
			
		}

		if (CanPressLever11 == true && Input.GetMouseButtonDown (0)) {
			//Rod8_on = !Rod8_on;
			//Rod8.SetActive(Rod8_on);
		
			print ("Rod8 should be toggled");
			cage.transform.position = new Vector3(-137,5,-117);
			
		}
	}


	void OnTriggerEnter(Collider other){
		//Trigger detection for levers

		if (other.gameObject.tag == "Lever1") {  
			print ("Touching a lever");
			CanPressLever1 = true;

		} else {
			CanPressLever1 = false;
		}

		// lever2
		if (other.gameObject.tag == "Lever2"){
			print("Touching lever2");
			CanPressLever2 = true;

		}else {
			CanPressLever2 = false;
		}

		//lever3
		if (other.gameObject.tag == "Lever3"){
			print("Touching a lever3");
			CanPressLever3 = true;
			
		}
		else {
			CanPressLever3 = false;
		}

		if (other.gameObject.tag == "Lever4"){
			print("Touching a lever4");
			CanPressLever4 = true;
			
		}
		else {
			CanPressLever4 = false;
		}

		if (other.gameObject.tag == "Lever5"){
			print("Touching a lever5");
			CanPressLever5 = true;
			
		}
		else {
			CanPressLever5 = false;
		}

		if (other.gameObject.tag == "Lever6"){
			print("Touching a lever6");
			CanPressLever6 = true;
			
		}else {
			CanPressLever6 = false;
		}

		if (other.gameObject.tag == "Lever7"){
			print("Touching a lever7");
			CanPressLever7 = true;
			
		}else {
			CanPressLever7 = false;
		}

		if (other.gameObject.tag == "Lever8"){
			print("Touching a lever8");
			CanPressLever8 = true;
			
		}else {
			CanPressLever8 = false;
		}

		if (other.gameObject.tag == "Lever9"){
			print("Touching a lever9");
			CanPressLever9 = true;
			
		}else {
			CanPressLever9 = false;
		}

		if (other.gameObject.tag == "Lever10"){
			print("Touching a lever10");
			CanPressLever10 = true;
			
		}else {
			CanPressLever10 = false;
		}

		if (other.gameObject.tag == "Lever11"){
			print("Touching a lever11");
			CanPressLever11 = true;
			
		}else {
			CanPressLever11 = false;
		}
		
}
	

}