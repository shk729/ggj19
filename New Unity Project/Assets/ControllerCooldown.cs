using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCooldown : MonoBehaviour
{
    
    public int cooldown = 2;
    public int cooldownPower = 3;
    public TextMesh texter;
    private int currentCooldown = 0;
    public int slowCooldown = 2;

    public PlayerContainer container;

    // Start is called before the first frame update
    void Start()
    {
    }

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

            var left =  Input.GetKey(container.key_left);
            var right = Input.GetKey(container.key_right);
            var up =    Input.GetKey(container.key_up);
            var down =  Input.GetKey(container.key_down);

            if (left)  container.platform.target.z += container.platform.rotationPower;
            if (right) container.platform.target.z -= container.platform.rotationPower;
            if (up)    container.platform.target.x += container.platform.rotationPower;
            if (down)  container.platform.target.x -= container.platform.rotationPower;
            if (left || right || up || down)
            {
                currentCooldown = cooldown;
                cooldown += cooldownPower;
            }
        }
        else currentCooldown--;

    }
}
