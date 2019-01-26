using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;
    public KeyCode up = KeyCode.W;
    public KeyCode down = KeyCode.S;
    public float thrust = 0.2f;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(up)) rb.AddForce( this.transform.forward * thrust);
        if (Input.GetKey(down)) rb.AddForce(this.transform.forward * -thrust);
        if (Input.GetKey(left)) rb.AddForce( this.transform.right * -thrust);
        if (Input.GetKey(right)) rb.AddForce(this.transform.right * thrust);
    }
}
