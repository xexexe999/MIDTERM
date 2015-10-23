using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SoapppTrigger : MonoBehaviour {
	
	public Text textUI;
	public Text textUI2;
	public GameObject SOAP;

	void OnTriggerStay() { 

		  if (GameManager.instance.waterin){
			textUI.text = "I: EAT SOAP";
			textUI2.text = "I: EAT SOAP";
			if (Input.GetKeyDown(KeyCode.I)){
				textUI.text = "YOU INGEST THE SOAP";
				textUI2.text = "YOU INGEST THE SOAP";
				GameManager.instance.soapin = true;
				SOAP.SetActive(false);}}
	
		else if (!GameManager.instance.hassoap & !GameManager.instance.fire2){
			textUI.text = "O: USE SOAP";
			textUI2.text = "O: USE SOAP";
			if (Input.GetKeyDown(KeyCode.O)){
				textUI.text = "YOU LATHER SOAP UPON YOUR BODY";
				textUI2.text = "YOU LATHER SOAP UPON YOUR BODY";
				GameManager.instance.hassoap = true;
		}
	}
	
	
}
}