using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour {
    public bool HasObject = false;
    public int points = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Coin" && HasObject == false)
        {
            Destroy(collision.collider.gameObject);
            HasObject = true;
        }

        if (collision.collider.name == "ScoreZone")
        {
            if(HasObject)
            {
                points += 1;
                HasObject = false;
            }
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
