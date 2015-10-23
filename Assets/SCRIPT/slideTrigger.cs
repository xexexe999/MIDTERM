using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class slideTrigger : MonoBehaviour {
	
	public Text textUI;
	public Text textUI2;
	public GameObject slider;
	void Start() {
		slider.SetActive(true);
	}



	void OnTriggerStay() { 
		if   (GameManager.instance.soaped && (Input.GetKeyDown (KeyCode.O) )){
				
				slider.SetActive(false);
		} else if (GameManager.instance.soaped){
			textUI.text = "O: SLIDE OPEN";
			textUI2.text = "O: SLIDE OPEN";}
		
		
		
		else {
			textUI.text = "YOUR SHOWER IS NOT OVER";
			textUI2.text = "YOUR SHOWER IS NOT OVER";}
		
	}

		
	}
	
	
