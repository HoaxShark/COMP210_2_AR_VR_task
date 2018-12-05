using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToMouse : MonoBehaviour {

    private float mouseOffset = 5.0f;
    public float movementSpeed = 1.0f;
    private FixedJoint m_FixedJoint;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //calculating the mouse position
        var MousePosition = Input.mousePosition; //taking input for the positioning of the mouse
        MousePosition.z = mouseOffset; // mouse offset to put the click on the right z axis
        MousePosition = Camera.main.ScreenToWorldPoint(MousePosition); //setting the position reading to local

        followMouse(MousePosition);
        keyboardInput();
    }

    void followMouse(Vector3 MousePosition)
    {
        transform.position = Vector3.MoveTowards(transform.position, MousePosition, movementSpeed); //move the arm towards lastPos

        //transform.position = MousePosition;
    }

    void keyboardInput()
    {
        if(Input.GetKey("w"))
        {
            mouseOffset += 0.1f;
        }
        
        if (Input.GetKey("s"))
        {
            mouseOffset -= 0.1f;
        }
    }
}

