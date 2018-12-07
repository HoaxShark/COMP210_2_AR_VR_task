using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisManager : MonoBehaviour {

    public GameObject thisObject;
    public float thrust; // initial thrust to start the debris moving

    private float xDirection; // used to set the x direction
    private float yDirection; // used to set the y direction
    private Rigidbody rb;
    private Vector3 direction; // stores the direction

    // Use this for initialization
    void Start () {
        xDirection = Random.Range(-5.0f, 5.0f); // get random x direction
        yDirection = Random.Range(-5.0f, 5.0f); // get random y direction
        rb = GetComponent<Rigidbody>();
        direction = new Vector3(xDirection, yDirection, -10.0f); // set direction to the new generated x and y values, also to the base z for the right direction
        rb.AddForce(direction * thrust); // add the the direction and thrust as force
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // if colliding with the end destroy itself
        if (collision.transform.tag == "End")
        {
            Destroy(thisObject);
        }
        // if hitting a wall reflect velocity and add an additional z to move away from the wall
        else if (collision.transform.tag == "Wall")
        {
            Vector3 newVelocity;
            newVelocity = Vector3.Reflect(collision.relativeVelocity * -1, collision.contacts[0].normal);
            newVelocity.z = newVelocity.z - 2.0f;
            rb.velocity = newVelocity;
        }
        // if colliding with anything else that isn't the player reflect the velocity to simulate bouncing
        else if (collision.transform.tag != "Player")
        {
            rb.velocity = Vector3.Reflect(collision.relativeVelocity * -1, collision.contacts[0].normal);
        }
    }
}
