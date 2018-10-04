using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlordScript : MonoBehaviour {

	[SerializeField]
	float moveSpeed = 10f;
	bool trapactive = false;
	Vector3 startPosition;
	Vector3 mover = new Vector3(0, 1, 0);
	
	[SerializeField]
	bool durationComplete;
	[SerializeField]
	float duration = 3;
	Collider m_collider;
	[SerializeField]
	string trapType;
	GameObject looker;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
		m_collider = GetComponent<Collider>();
		m_collider.enabled = false;
		looker = GameObject.Find("CooldownHolder");
		looker.GetComponent("CoolHolder");
		//trapType = gameObject.tag;//gets trap type so it knows which input activates it
	}

	// Update is called once per frame
	void Update () {	
		if(Input.GetKeyDown(trapType) && looker.GetComponent<CoolHolder>().coolDownComplete)
		{
			trapactive = true;
			looker.GetComponent<CoolHolder>().timeStamp = Time.time + looker.GetComponent<CoolHolder>().universalCooldown;
			durationComplete = false;
			looker.GetComponent<CoolHolder>().coolDownComplete = false;
			
		}
	}

	void FixedUpdate()
	{
		if(trapactive)
		{
			GetComponent<Renderer>().material.color = new Color(0, 255, 0);
			m_collider.enabled = true;
			GetComponent<Collider>().isTrigger = true;
			if(trapType == "Saw")//pick animation for trap going off or more specific hitboxes
			{

			}
			if (trapType == "Fire")//pick animation for trap going off or more specific hitboxes
			{

			}
			if (trapType == "Pitfall")//pick animation for trap going off or more specific hitboxes
			{

			}
			if (trapType == "Fish")//pick animation for trap going off or more specific hitboxes
			{

			}
		}
		if(!looker.GetComponent<CoolHolder>().coolDownComplete)
		{
			cooldown();
		}
		
	}

	void cooldown()
	{
		if (looker.GetComponent<CoolHolder>().timeStamp <= Time.time)
		{
			looker.GetComponent<CoolHolder>().coolDownComplete = true;
		}
	}
}
