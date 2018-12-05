using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalls : MonoBehaviour {

    public GameObject[] Walls; // array of all wall objects

    private Vector3 spawnLocation = new Vector3(0.0f,0.0f,150.0f); // base spawn location

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        foreach (GameObject wall in Walls)
        {
           if (wall.transform.position.z <=  -19.0f) // if wall is past the point of being unseen
            {
                Quaternion newRotation;
                wall.transform.position = spawnLocation; // move wall back to the spawn location
                newRotation = Random.rotation; // generate a random rotation
                newRotation.x = 0; // set x and y rotation to 0
                newRotation.y = 0;
                wall.transform.rotation = newRotation; // pass new rotation to the wall
            }
        }
    }
}
