using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WaterTrigger : MonoBehaviour {
	
	public Text textUI;
	public Text textUI2;


	void OnTriggerEnter() { 
		if (!GameManager.instance.warm){
			Application.LoadLevel("cold");}


		}
		

	void OnTriggerStay() { 
		if (GameManager.instance.fire2 && Input.GetKeyDown (KeyCode.O)){
			textUI.text = "YOU SWALLOW ALL THE WATER YOU CAN";
			textUI2.text = "YOU SWALLOW ALL THE WATER YOU CAN";
			GameManager.instance.waterin = true;
		}
		else if (GameManager.instance.fire2 && !GameManager.instance.waterin){
			textUI.text = "YOU HAVE NO WAY TO TRANSPORT THE WATER..."+"\nO: THINK HARDER";
			textUI2.text = "YOU HAVE NO WAY TO TRANSPORT THE WATER..."+"\nO: THINK HARDER";

			}
		

		else if (GameManager.instance.hassoap){
				textUI.text = "I: RINSE";
				textUI2.text = "I: RINSE";
			if (Input.GetKeyDown (KeyCode.I)){
				textUI.text = "YOU ARE RINSED OF SOAP";
				textUI2.text = "YOU ARE RINSED OF SOAP";
				GameManager.instance.soaped = true;
				GameManager.instance.hassoap = false;
			}

				}
		else if (!GameManager.instance.hassoap && !GameManager.instance.soaped){
			textUI.text = "~~_**";
			textUI2.text = "~~_**";	
		
	}
	

}
}