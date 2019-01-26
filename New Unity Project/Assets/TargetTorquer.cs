using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTorquer : MonoBehaviour
{
    public enum Direction { left, up, down, right };

    public PlatformControl platform;
    public Direction dr = Direction.down;
    public int coolDown = 25;
    private int currentCooldown = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (currentCooldown > 0) return;
        currentCooldown = coolDown;
        if ( dr == Direction.left) platform.target.z += platform.rotationPower;
        if (dr == Direction.right) platform.target.z -= platform.rotationPower;
        if (dr == Direction.up) platform.target.x += platform.rotationPower;
        if (dr == Direction.down) platform.target.x -= platform.rotationPower;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentCooldown > 0) currentCooldown--;
    }

    
}
