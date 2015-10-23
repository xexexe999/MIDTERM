using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class theend : MonoBehaviour {
	public float tyty = 7f;

	// Use this for initialization

		
	// Update is called once per frame
	void Update () {
		tyty -= Time.deltaTime;
			if (tyty < 3f) {
			Application.LoadLevel("wwwww");
	}
	}}
