using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControl : MonoBehaviour {
    float rotPower = 0.005f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //float v = Input.GetAxis("Vertical");
        //float h = Input.GetAxis("Horizontal");

        var rot = this.transform.rotation;


        if (Input.GetKey(KeyCode.A)) rot.z += rotPower;
        if (Input.GetKey(KeyCode.D)) rot.z -= rotPower;
        if (Input.GetKey(KeyCode.W)) rot.x += rotPower;
        if (Input.GetKey(KeyCode.S)) rot.x -= rotPower;

        //this.transform.ro
        this.transform.rotation = rot;
	}
}
