using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class lighterTrigger : MonoBehaviour {
	
	public Text textUI;
	public Text textUI2;

	public GameObject fireee;
	void Start () {

		fireee.SetActive(false);
	}  
	void Update(){

	}
	void OnTriggerEnter() { 
		if (GameManager.instance.haircut&& !GameManager.instance.fire){
			textUI.text = "I: SET HAIR ON FIRE";
			textUI2.text = "I: SET HAIR ON FIRE";}

		else if (GameManager.instance.uhoh && !GameManager.instance.fire && !GameManager.instance.fire2){
			textUI.text = "YOU DON'T HAVE ANYTHING EASILY FLAMMABLE RIGHT NOW";
			textUI2.text = "YOU DON'T HAVE ANYTHING EASILY FLAMMABLE RIGHT NOW";}


		
	}
	void OnTriggerStay() { 
		if   (GameManager.instance.haircut && (Input.GetKeyDown (KeyCode.I)) ){
				
				fireee.SetActive(true);
			GameManager.instance.fire = true;
			textUI.text = "YOUR HAIR CATCHES FIRE INSTANTLY";
			textUI2.text = "YOUR HAIR CATCHES FIRE INSTANTLY";
			 }

		
	}
	
	void OnTriggerExit () {
		if (GameManager.instance.fire && !GameManager.instance.fire2){
		textUI2.text = "BUT THE FIRE IS SMALL AND THERES BARELY ANY SMOKE";
			textUI.text = "BUT THE FIRE IS SMALL AND THERES BARELY ANY SMOKE";}

		}
	}

