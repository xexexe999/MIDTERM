using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class justrightTrigger : MonoBehaviour {
	
	public Text textUI;
	public Text textUI2;


	void Update() { 

			if (Input.GetKeyDown(KeyCode.O)){
			textUI.text = "CANDLELIGHT AND A MIRROR" +"\nPress I for full solution" + "\nPress SPACE to restart";
			textUI2.text = "CANDLELIGHT AND A MIRROR" +"\nPress I for full solution"+ "\nPress SPACE to restart";}
			if (Input.GetKeyDown(KeyCode.I)){
				textUI.text = "INSTEAD OF PUTTING OUT THE FIRE WITH WATER" + "\nTURN OFF THE LIGHTS AND USE THE MIRROR"+ "\nPress SPACE to restart";
				textUI2.text = "INSTEAD OF PUTTING OUT THE FIRE WITH WATER" + "\nTURN OFF THE LIGHTS AND USE THE MIRROR"+ "\nPress SPACE to restart";
			}
	
	
}

}