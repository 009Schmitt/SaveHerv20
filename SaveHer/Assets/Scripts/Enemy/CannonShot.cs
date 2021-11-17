using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShot : MonoBehaviour
{
    public LayerMask ground;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>().GetComponent<Transform>();
        transform.LookAt(player, Vector3.forward);
        print("Executa");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,0,.15f));
        if(Physics.CheckSphere(transform.position,.3f,ground))
        {
            Destroy(gameObject);
        }
    }
}
