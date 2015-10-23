using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class alarmTrigger : MonoBehaviour {
	
	public Text textUI;
	public Text textUI2;




	void OnTriggerEnter() { 
		if (GameManager.instance.uhoh && !GameManager.instance.fire2){
			textUI.text = "HMM.. SETTING OFF THIS SMOKE ALARM WOULD DEFINITELY SCARE THEM OFF... BUT HOW?";
			textUI2.text = "HMM.. SETTING OFF THIS SMOKE ALARM WOULD DEFINITELY SCARE THEM OFF... BUT HOW?";}

		
	}
	

}
