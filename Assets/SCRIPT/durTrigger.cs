using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class durTrigger : MonoBehaviour {
	
	public Text textUI;
	public Text textUI2;
	public GameObject wicked;

	void Start () {

		wicked.SetActive(false);
	}  

	void OnTriggerEnter() { 
	
			textUI.text = "CLICK: EXIT";
			textUI2.text = "CLICK: EXIT";}

		
		

	void OnTriggerStay() { 
			if   ((GameManager.instance.ext) && Input.GetMouseButtonDown(0) ){
		Application.LoadLevel("just right");
			 }
		else if (Input.GetMouseButtonDown(0)){
			textUI.text = "... IT SEEMS THAT WHILE YOU WERE SHOWERING YOUR FIANCEE'S FAMILY DROPPED IN AFTER CHURCH" + "\n...";
		textUI2.text = "... IT SEEMS THAT WHILE YOU WERE SHOWERING YOUR FIANCEE'S FAMILY DROPPED IN AFTER CHURCH" + "\n...";
		if (Input.GetMouseButtonDown(0)){ 
			textUI.text = "YOU CAN'T GO OUT NAKED, AND THERE'S NO WAY YOU'RE GOING OUT IN SOGGY UNDERWEAR";
			textUI2.text = "YOU CAN'T GO OUT NAKED, AND THERE'S NO WAY YOU'RE GOING OUT IN SOGGY UNDERWEAR";
		}
			wicked.SetActive(true);
			GameManager.instance.uhoh = true;
		    }
		
	}
	
	void OnTriggerExit () {
		textUI2.text = " ";
		textUI.text = " ";
	}
}
