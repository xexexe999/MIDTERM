using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class invisTrigger : MonoBehaviour {
	
	public Text textUI;
	public Text textUI2;
	public GameObject blox;
	void Start (){
		blox.SetActive(true);}
	void OnTriggerStay() { 
		if (!GameManager.instance.dry){

		textUI.text = "YOU'VE FORGOTTEN TO BRING A TOWEL AS USUAL"+"\nI: DRY YOURSELF WITH UNDERWEAR";
		textUI2.text = "YOU'VE FORGOTTEN TO BRING A TOWEL AS USUAL"+"\nI: DRY YOURSELF WITH UNDERWEAR";
		 
		if (Input.GetKeyDown (KeyCode.I) && !GameManager.instance.dry){
				textUI.text = "YOU DRY YOURSELF. NOW YOU JUST NEED TO MAKE IT TO THE BEDROOM AND GET SOME CLOTHES..";
				textUI2.text = "YOU DRY YOURSELF. NOW YOU JUST NEED TO MAKE IT TO THE BEDROOM AND GET SOME CLOTHES..";
			blox.SetActive(false);
			GameManager.instance.dry = true;

		}
		}}
		

	
	void OnTriggerExit () {
		textUI2.text = " ";
		textUI.text = " ";
	}
}
