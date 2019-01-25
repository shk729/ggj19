using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControl : MonoBehaviour {
    
    public int step = 50;
    public float rotationPower = 0.05f;
    //public Rigidbody body;

    public Quaternion target;
    

	// Use this for initialization
	void Start () {
        target = transform.rotation;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        var cur = transform.rotation;
        cur.x += (target.x - cur.x) / step;
        cur.z += (target.z - cur.z) / step;
        transform.rotation = cur;
    }

    /*
        //float v = Input.GetAxis("Vertical");
        //float h = Input.GetAxis("Horizontal");
    void TorqMovement()
    {
        
        if (Input.GetKey(KeyCode.A)) body.AddTorque(transform.forward * rotPower);
        if (Input.GetKey(KeyCode.D)) body.AddTorque(transform.forward * -rotPower);
        if (Input.GetKey(KeyCode.W)) body.AddTorque(transform.right * rotPower);
        if (Input.GetKey(KeyCode.S)) body.AddTorque(transform.right * -rotPower);
    }

    void DefaultMovement()
    {
        var rot = this.transform.rotation;
        if (Input.GetKey(KeyCode.A)) rot.z += rotPower;
        if (Input.GetKey(KeyCode.D)) rot.z -= rotPower;
        if (Input.GetKey(KeyCode.W)) rot.x += rotPower;
        if (Input.GetKey(KeyCode.S)) rot.x -= rotPower;
        this.transform.rotation = rot;
    } */
}
