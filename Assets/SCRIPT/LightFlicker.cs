using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour
{


    public Light flickeryLight; // assign in Inspector

    // Update is called once per frame
    void Update()
    { 
		if (GameManager.instance.lightsout3){
			flickeryLight.intensity = Random.Range(0f, 0.1f);
		} else if (GameManager.instance.lightsout2){
			flickeryLight.intensity = Random.Range(0.2f, 1.1f);
		}
		else if (GameManager.instance.lightsout1){
			flickeryLight.intensity = Random.Range(1f, 1.5f);
		}
       else { flickeryLight.intensity = Random.Range(1.7f, 2f);
    }
	}}