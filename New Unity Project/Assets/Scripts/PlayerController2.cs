using UnityEngine;
using System.Collections;

public class PlayerController2 : MonoBehaviour {

    public float speed = 18;

    public float turnSpeed = 60;

    private Rigidbody rig;

	// Use this for initialization
	void Start ()
    {
        rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
    {

        //float dPadX = Input.GetAxis("X360_DPadX");

        //float dPadY = Input.GetAxis("X360_DPadY");

        //float triggerAxis = Input.GetAxis("X360_Triggers");

       
       
        if (Input.GetButtonDown("AButton"))
        {
            print("A Button");
        }
        if (Input.GetButtonDown("BButton"))
        {
            print("B Button");
        }
        if (Input.GetButtonDown("XButton"))
        {
            print("X Button");
        }
        if (Input.GetButtonDown("YButton"))
        {
            print("Y Button");
        }
        if (Input.GetButtonDown("SelectButton"))
        {
            print("Back Button");
        }
        if (Input.GetButtonDown("StartButton"))
        {
            print("Start Button");
        }
  

        float hAxis = Input.GetAxis("LeftJoystickH2");
        float vAxis = Input.GetAxis("LeftJoystickV2");

        Vector3 movement = new Vector3(-hAxis, 0, vAxis);
        transform.Translate( movement * speed * Time.deltaTime, Space.World);
        transform.rotation = Quaternion.LookRotation(movement);

        // Vector3 movement = transform.TransformDirection(new Vector3(-hAxis, 0, vAxis) * speed * Time.deltaTime);

        //rig.MovePosition(transform.position + movement);

        //Quaternion rotation = Quaternion.Euler(new Vector3(0, rStickX, 0) * turnSpeed * Time.deltaTime);

        // transform.Rotate(new Vector3(0, rStickX, 0), turnSpeed * Time.deltaTime);
    }
}
