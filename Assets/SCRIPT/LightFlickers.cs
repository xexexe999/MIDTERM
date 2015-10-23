using UnityEngine;
using System.Collections;

public class LightFlickers : MonoBehaviour
{


    public Light flickeryLight; // assign in Inspector

    // Update is called once per frame
	void Update()
	{ if (GameManager.instance.lightsout3){
			flickeryLight.intensity = Random.Range(0f, 0.1f);
		}

		else if (GameManager.instance.lightsout2){
			flickeryLight.intensity = Random.Range(0.5f, 0.9f);
		}
		else if (GameManager.instance.lightsout1){
			flickeryLight.intensity = Random.Range(1.3f, 1.7f);
		}
		else { flickeryLight.intensity = Random.Range(1.9f, 2.2f);
		}
	}}