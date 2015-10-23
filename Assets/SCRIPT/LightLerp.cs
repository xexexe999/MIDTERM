using UnityEngine;
using System.Collections;

public class LightLerp : MonoBehaviour
{
	float time = 0f; // time will be a number from 0 to 1

    public Light flickeryLight; // assign in Inspector

    // Update is called once per frame
    void Update()
	{
		time += Time.deltaTime / 3f; 
		flickeryLight.intensity = Mathf.Lerp(0f, 8f, Mathf.Sin (Time.time * 3f) );
    }
}