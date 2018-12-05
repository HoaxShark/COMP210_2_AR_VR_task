using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    /* scales down the health bar comaritive to the players health.
       will need slight refactoring if the player has a starting helth different to 100 */

    public Player player; // Reference to player

    private Vector3 maxScale; // biggest the health bar will be
    private Vector3 newScale; //  the new scale of the health bar
    private float onePercent; //  percent of the health bar size

    // Use this for initialization
    void Start () {
        maxScale = this.transform.localScale; // set max scale
        newScale = maxScale; // sets base of new scale
        onePercent = maxScale.y / 100.0f; // calulate one percent of max
	}
	
	// Update is called once per frame
	void Update () {
        newScale.y = onePercent * player.health; // newScale on the Y becomes the players health times one perecent the max scale
        this.transform.localScale = newScale; // set new scale
	}
}
