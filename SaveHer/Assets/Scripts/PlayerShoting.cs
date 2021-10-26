using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoting : MonoBehaviour
{
    public GameObject projectile;
    public Transform spawn;

    public float shotCooldown;
    private float actualCooldown;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && actualCooldown < Time.time)
        {
            if (spawn.rotation.y > 0)
            {
                Instantiate(projectile, spawn.position, new Quaternion(0, 0, -1, 1));
            }
            else
            {
                Instantiate(projectile, spawn.position, new Quaternion(0, 0, 1, 1));
            }
            actualCooldown = Time.time + shotCooldown;
        }

    }
}
