using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public LayerMask mask;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.CheckSphere(new Vector3(this.transform.position.x, 0, 0), .12f, mask))
        {
            Destroy(bullet);
        }
    }
}
