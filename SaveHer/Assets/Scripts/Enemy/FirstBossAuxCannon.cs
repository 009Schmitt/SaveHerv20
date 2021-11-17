using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBossAuxCannon : MonoBehaviour
{
    public GameObject fireBall;
    public float coolDown;

    private float actualTime;

    private void Start()
    {
        actualTime = coolDown + Time.time;
    }


    // Update is called once per frame
    void Update()
    {
        if (actualTime < Time.time)
        {
            if(Random.Range(1,101) > 50)
            {
                actualTime += coolDown;
                Instantiate(fireBall, transform.position, new Quaternion());
            }
            else
            {
                actualTime += coolDown / 2;
            }
        }
    }
}
