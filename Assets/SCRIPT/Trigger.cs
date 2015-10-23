using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Trigger : MonoBehaviour {
	
	public Text textUI;
	public Text textUI2;
	public GameObject hair;

	void Start () {
		hair.SetActive(false);

	}  

	void OnTriggerEnter() { 
		if (GameManager.instance.uhoh){
			textUI.text = "O: USE SCISSORS";
			textUI2.text = "O: USE SCISSORS";}

		
	}
	void OnTriggerStay() { 

		if (Input.GetKeyDown (KeyCode.O) && GameManager.instance.uhoh){
			textUI.text = "YOU HAVE MUCH LESS HAIR NOW";
			textUI2.text = "YOU HAVE MUCH LESS HAIR NOW";
			hair.SetActive(true);
			GameManager.instance.haircut = true;}
		
	}
	

}
