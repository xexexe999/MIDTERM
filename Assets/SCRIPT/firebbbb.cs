using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class firebbbb : MonoBehaviour {
	public float rere = 53f;

	// Use this for initialization

		
	// Update is called once per frame
	void Update () {
		rere -= Time.deltaTime;
			if (rere < 3f) {
			Application.LoadLevel("HOT");
	}
	}}
