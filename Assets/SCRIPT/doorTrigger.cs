using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class doorTrigger : MonoBehaviour {
	
	public Text textUI;
	public Text textUI2;

	public GameObject wicked;
	void Start () {

		wicked.SetActive(false);
	}  

	void OnTriggerEnter() { 
	
			textUI.text = "I: EXIT";
			textUI2.text = "I: EXIT";}

		
		

	void OnTriggerStay() { 
		if   (GameManager.instance.ext && Input.GetKeyDown (KeyCode.I)){
		Application.LoadLevel("just right");
			 }
		else if (GameManager.instance.fire2 && Input.GetKeyDown (KeyCode.I) ){
			textUI.text = "YOU SHOULD PROBABLY PUT OUT THE FIRE...";
			textUI2.text = "YOU SHOULD PROBABLY PUT OUT THE FIRE..";
		}
		else if (Input.GetKeyDown (KeyCode.I) && GameManager.instance.soaped){
			textUI.text = "... IT SEEMS THAT WHILE YOU WERE SHOWERING YOUR FIANCEE'S FAMILY DROPPED IN AFTER CHURCH ...";
		textUI2.text = "... IT SEEMS THAT WHILE YOU WERE SHOWERING YOUR FIANCEE'S FAMILY DROPPED IN AFTER CHURCH ...";
		       
			wicked.SetActive(true);
			GameManager.instance.uhoh = true;
		    }
		
	}
	
	void OnTriggerExit () {
		if (GameManager.instance.uhoh && !GameManager.instance.fire2){
		textUI.text = "YOU CAN'T GO OUT NAKED, AND THERE'S NO WAY YOU'RE GOING OUT IN SOGGY UNDERWEAR";
		textUI2.text = "YOU CAN'T GO OUT NAKED, AND THERE'S NO WAY YOU'RE GOING OUT IN SOGGY UNDERWEAR";
	}
}
}