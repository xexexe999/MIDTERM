using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class mirrorTrigger : MonoBehaviour {
	
	public Text textUI;
	public Text textUI2;
	public GameObject flick;
	public GameObject flick2;
	public GameObject end2;

void Start(){
		end2.SetActive(false);
	}
	void OnTriggerEnter() {

		if (GameManager.instance.lightsout){
		
	
			textUI.text = "O: ...SAY BLOODY MARY";
			textUI2.text = "O: ...SAY BLOODY MARY";}
	
	}
		

	void OnTriggerStay() { 
		if   (GameManager.instance.lightsout2 && Input.GetKeyDown (KeyCode.O) ){
			textUI.text = "THE FIRE IS BLOWN OUT";
			textUI2.text = "THE FIRE IS BLOWN OUT"; 
			GameManager.instance.lightsout3 = true;
			end2.SetActive(true);
		}
		else if   (GameManager.instance.lightsout1 && Input.GetKeyDown (KeyCode.I) ){
			textUI.text = "O: SAY BLOODY MARY";
			textUI2.text = "O: SAY BLOODY MARY"; 
			GameManager.instance.lightsout2 = true;
		}
		else if   (GameManager.instance.lightsout && Input.GetKeyDown (KeyCode.O) ){
			textUI.text = "I: SAY BLOODY MARY";
			textUI2.text = "I: SAY BLOODY MARY"; 
			GameManager.instance.lightsout1 = true;


		}}
		


	

}
