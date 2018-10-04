using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolHolder : MonoBehaviour {

	public float universalCooldown = 5f;
	public bool coolDownComplete;
	public float timeStamp = 0;

	// Use this for initialization
	void Start () {
		coolDownComplete = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public float getUniCool()
	{
		return universalCooldown;
	}
}
