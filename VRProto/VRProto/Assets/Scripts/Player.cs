using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float health = 100;
    public float damage;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(health);
        if (Input.GetKeyDown(KeyCode.R)) // restart scene on R
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (health <= 0) // restart scene on 0 health
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}

    public void CollisionDetected(Collision collision)
    {
        if (collision.transform.tag == "Wall") // if colliding with a wall reduce health
        {
            health -= damage;
        }
        if (collision.transform.tag == "End") // if hiting the end of the map restart
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
