using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControl : MonoBehaviour {
    public float rotPower = 0.005f;
    public int cooldown = 25;
    public int step = 50;
    public Rigidbody body;

    private Quaternion target;
    private int currentCooldown = 0;

	// Use this for initialization
	void Start () {
        target = this.transform.rotation;

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //float v = Input.GetAxis("Vertical");
        //float h = Input.GetAxis("Horizontal");

        StepMovement();
	}

    void StepMovement()
    {
        
        if (currentCooldown <= 0)
        {
            if (Input.GetKey(KeyCode.A)) target.z += rotPower;
            if (Input.GetKey(KeyCode.D)) target.z -= rotPower;
            if (Input.GetKey(KeyCode.W)) target.x += rotPower;
            if (Input.GetKey(KeyCode.S)) target.x -= rotPower;
            if (Input.anyKey) currentCooldown = cooldown;
        }
        else currentCooldown--;
        var cur = transform.rotation;
        cur.x += (target.x - cur.x) / step;
        cur.z += (target.z - cur.z) / step;

        this.transform.rotation = cur;
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, target, turningRate);
        //this.transform.rotation = rot;


    }

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
    }
}
