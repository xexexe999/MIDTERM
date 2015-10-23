using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public static GameManager instance;  // if it refers to itself, 'anyone' can 'talk' to it
    
	public bool warm = false;
	public bool hassoap = false;
   public bool soaped = false;
	public bool dry = false;
	public bool uhoh = false; 
	public bool haircut = false;
	public bool fire = false;
	public bool fire2 = false;
	public bool lightsout = false;
	public bool lightsout1 = false;
	public bool lightsout2 = false;
	public bool lightsout3 = false;
	public bool waterin = false;
	public bool soapin = false;
	public bool ext = false; 


    
    // Use this for initialization
    void Start () {
		warm = false;
		hassoap = false;
		 soaped = false;
		 dry = false;
		ext = false;
		uhoh = false; 
		haircut = false;
		 fire = false;
		fire2 = false; 
		lightsout = false;
		lightsout1 = false;
		lightsout2 = false;
		lightsout3 = false;
		waterin = false;
		soapin = false;
        instance = this; // THIS refers to whatever the script is on!
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > 4.5f){
			warm = true;}
    }
}
