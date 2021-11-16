using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShot : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(player, Vector3.forward);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,0,.15f));
    }
}
