using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class switchTrigger : MonoBehaviour {
	
	public Text textUI;
	public Text textUI2;

	public GameObject lightu;



	void OnTriggerEnter() {

		if (GameManager.instance.fire2){
		
	
			textUI.text = "I: SWITCH OFF";
			textUI2.text = "I: SWITCH OFF";}
	
	}
		

	void OnTriggerStay() { 
		if   (GameManager.instance.fire2 && Input.GetKeyDown (KeyCode.I) ){
				lightu.SetActive(false);
			GameManager.instance.lightsout = true;
		}}
		
		

	

}
