using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDebris : MonoBehaviour {

    public Rigidbody Debris; // array of all wall objects

    public Transform spawnLocation; //new Vector3(0.0f, 0.0f, 100.0f); // base spawn location

    // Use this for initialization
    void Start()
    {
        StartCoroutine(CheckAndSpawn()); // start the spawning function
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CheckAndSpawn()
    {
        // if there are less than 5 debris in the scene spawn another and wait some seconds and check again
        if (GameObject.FindGameObjectsWithTag("Debris").Length < 5)
        {
            Instantiate(Debris, spawnLocation.position, transform.rotation);
            yield return new WaitForSeconds(15);
            StartCoroutine(CheckAndSpawn());
        }
    }
}
