using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SoapTrigger : MonoBehaviour {
	
	public Text textUI;
	public Text textUI2;
	public GameObject hair;
	void Start () {
		hair.SetActive(false);

	}  
	

	void OnCollisionStay(Collision col) { 
		if (col.gameObject.name == "showerwater"){
			textUI.text = "YOU USED THE SOAP";
			textUI2.text = "YOU USED THE SOAP";
	
		}}
	
	void OnCollisionExit () {
		textUI2.text = " ";
		textUI.text = " ";
	}
}
