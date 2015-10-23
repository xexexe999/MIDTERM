using UnityEngine;
using System.Collections;

public class intromenu : MonoBehaviour {
    //USE 'static' KEYWORD TO MAKE STUFF PERSIST IN CODE INSTEAD OF JUST SCENE

	public static bool useNightMare = false; 
	// Use this for initialization
	void Start () {    useNightMare = false;

    //so that a restarted scene doesnt contain spillover from earlier (cos of static)
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            Application.LoadLevel("MIDTERM");
    
    }
}
