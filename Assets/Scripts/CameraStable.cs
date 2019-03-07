using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour {

    public GameObject car;
    public Vector3 car_position;
	
	void Update ()
    {
        car_position = car.transform.eulerAngles;

        transform.eulerAngles = new Vector3(car_position.x - car_position.x, car_position.y, car_position.z - car_position.z);
    }
}
