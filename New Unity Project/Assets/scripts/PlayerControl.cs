using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public PlatformControl platform;

    public int cooldown = 25;

    public KeyCode key_left = KeyCode.A;
    public KeyCode key_right = KeyCode.D;
    public KeyCode key_up = KeyCode.W;
    public KeyCode key_down = KeyCode.S;

    private int currentCooldown = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentCooldown <= 0)
        {
            if (Input.GetKey(key_left)) platform.target.z += platform.rotationPower;
            if (Input.GetKey(key_right)) platform.target.z -= platform.rotationPower;
            if (Input.GetKey(key_up))    platform.target.x += platform.rotationPower;
            if (Input.GetKey(key_down))  platform.target.x -= platform.rotationPower;
            if (Input.anyKey) currentCooldown = cooldown;
        }
        else currentCooldown--;
    }
}
