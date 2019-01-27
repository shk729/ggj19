using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMe : MonoBehaviour
{
    public float force = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        //this.GetComponent<Rigidbody>().(transform.forward * force);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var rot = transform.rotation;
        Vector3 vec3 = rot.eulerAngles;
        vec3.z += force;
        transform.rotation = Quaternion.Euler(vec3);
    }
}
