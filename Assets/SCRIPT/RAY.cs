


using UnityEngine;
using System.Collections;

public class RAY : MonoBehaviour {
	void Update() {
		RaycastHit hit;
		Vector3 forward = transform.TransformDirection (Vector3.forward) * 20;
		Debug.DrawRay (transform.position, forward, Color.red);
		if (Physics.Raycast(transform.position, forward, out hit)) {
			print (hit.collider.gameObject.name);
		}
	}
}