using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPart : MonoBehaviour {

    public Player player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // sends the collision over to the player
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Wall" | collision.collider.tag == "End" | collision.collider.tag == "Debris")
        {
            player.CollisionDetected(collision);
        }
    }
}
