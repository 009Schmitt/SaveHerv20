using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFire : MonoBehaviour
{
    public GameObject fireBall;
    public float coolDown;
    public Transform spawnPosition;

    private float actualTime;
    // Start is called before the first frame update
    void Start()
    {
        actualTime = coolDown + Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (actualTime < Time.time)
        {
            actualTime += coolDown + (FindObjectOfType<FirstBossLife>().life / 100);
            Instantiate(fireBall, spawnPosition.position,new Quaternion());
        }
    }
}
