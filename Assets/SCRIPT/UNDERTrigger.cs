using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UNDERTrigger : MonoBehaviour {
	
	public Text textUI;
	public Text textUI2;
	public GameObject under;
	public GameObject vomit;
	public GameObject fireu;
	public GameObject fireu2;
	public GameObject alarm;
	public GameObject alarmLIGHT;
	public GameObject wikk;
	void Start () {
		vomit.SetActive(false);
		fireu.SetActive(false);
		alarm.SetActive (false);
		alarmLIGHT.SetActive(false);
	}  
	void Update(){

	}
	void OnTriggerEnter() {
		if (GameManager.instance.soapin&& !GameManager.instance.ext){
			textUI.text = "O: VOMIT";
			textUI2.text = "O: VOMIT";}
		else if (!GameManager.instance.soapin&& GameManager.instance.waterin){
			textUI.text = "YOU TRY... BUT ITS JUST NOT COMING" + "\nYOU NEED A STRONGER URGE TO VOMIT";
			textUI2.text = "YOU TRY... BUT ITS JUST NOT COMING" + "\nYOU NEED A STRONGER URGE TO VOMIT";}
		else if (GameManager.instance.fire && !GameManager.instance.fire2){
			textUI.text = "I: ADD UNDERWEAR TO FIRE";
			textUI2.text = "I: ADD UNDERWEAR TO FIRE";}
		 

		
	}
	void OnTriggerStay() { 
		if (GameManager.instance.soapin && Input.GetKeyDown (KeyCode.O)){
			vomit.SetActive(true);
			fireu.SetActive(false);
			fireu2.SetActive(false);
			GameManager.instance.ext = true;
			alarm.SetActive(false);
			alarmLIGHT.SetActive(false);
			textUI.text = "YOUR PUKE PUTS THE FIRE OUT";
			textUI2.text = "YOUR PUKE PUTS THE FIRE OUT";

		}
		else if   (GameManager.instance.fire && Input.GetKeyDown (KeyCode.I) && !GameManager.instance.fire2){
				transform.position += new Vector3(30f, 0f, 0f);
				GameManager.instance.fire2 = true;
				fireu.SetActive(true);
			alarm.SetActive(true);
			alarmLIGHT.SetActive(true);
			wikk.SetActive(false);
			textUI.text = "THE FIRE CACKLES AND EXPANDS" + "\nYOU HEAR THE FAMILY SCAMPERING AWAY, PANICKED";
			textUI2.text = "THE FIRE CACKLES AND EXPANDS" + "\nYOU HEAR THE FAMILY SCAMPERING AWAY, PANICKED";
			 }

		
	}

}
