/* TODO
 * -Get customer to ride
 * -Set waypoint - pathfinding
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fare : MonoBehaviour
{
    private enum state { WAITING, RIDING, COMPLETE};

    public GameObject destinationWaypoint;
    private state currentState;

    // Use this for initialization
    void Start ()
    {
        currentState = state.WAITING;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(" FARE CURRENT STATE: " + currentState);
	}

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.name == "ArcadeCar")
        {
            currentState = state.RIDING;
        }
    }
}
