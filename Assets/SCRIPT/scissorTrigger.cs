using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scissorTrigger : MonoBehaviour {
	
	public Text textUI;
	public Text textUI2;
	public GameObject under;
	public GameObject blox;
	public GameObject fireu;
	void Start () {
		blox.SetActive(true);
		fireu.SetActive(false);
	}  
	void Update(){

	}
	void OnTriggerEnter() { 
		if (GameManager.instance.fire){
			textUI.text = "CLICK: ADD UNDERWEAR TO FIRE";
			textUI2.text = "CLICK: ADD UNDERWEAR TO FIRE";}

		if (GameManager.instance.dry){
			textUI.text = " ";
			textUI2.text = " ";}
		
		else {
			textUI.text = "CLICK: DRY YOURSELF WITH UNDERWEAR";
			textUI2.text = "CLICK: DRY YOURSELF WITH UNDERWEAR";}
		
	}
	void OnTriggerStay() { 
			if   (GameManager.instance.fire && Input.GetMouseButtonDown(0) ){
				transform.position += new Vector3(30f, 0f, 0f);
				GameManager.instance.fire2 = true;
				fireu.SetActive(true);
			 }
		if (Input.GetMouseButtonDown(0)){
			textUI.text = "YOU DRY YOURSELF";
			textUI2.text = "YOU DRY YOURSELF";
			blox.SetActive(false);
			GameManager.instance.dry = true;
		    }
		
	}
	
	void OnTriggerExit () {
		textUI2.text = " ";
		textUI.text = " ";
	}
}
