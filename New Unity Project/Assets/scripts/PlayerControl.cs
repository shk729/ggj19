using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public PlatformControl platform;

    public int cooldown = 2;
    public int cooldownPower = 3;
    public TextMesh texter;

    public KeyCode key_left = KeyCode.A;
    public KeyCode key_right = KeyCode.D;
    public KeyCode key_up = KeyCode.W;
    public KeyCode key_down = KeyCode.S;

    private int currentCooldown = 0;
    public int slowCooldown = 2;

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (currentCooldown <= 0)
        {
            texter.text = this.name + ": " + cooldown;
            if (slowCooldown-- <= 0)
            {
                slowCooldown = cooldown--;
                if (cooldown < 2) cooldown = 1;
                
            }

            var left = Input.GetKey(key_left);
            var right = Input.GetKey(key_right);
            var up = Input.GetKey(key_up);
            var down = Input.GetKey(key_down);

            if (left) platform.target.z += platform.rotationPower;
            if (right) platform.target.z -= platform.rotationPower;
            if (up)    platform.target.x += platform.rotationPower;
            if (down)  platform.target.x -= platform.rotationPower;
            if (left || right || up || down)
            {
                currentCooldown = cooldown;
                cooldown += cooldownPower;
            }
        }
        else currentCooldown--;

    }
}
