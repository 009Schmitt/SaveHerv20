using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemyMove : MonoBehaviour
{
    public LayerMask wall;
    public Transform checkWall;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // enemy flip
        if(Physics.CheckSphere(checkWall.position,0.3f,wall))
        {
            if(this.transform.eulerAngles.y > 0)
            {
                this.transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else
            {
                this.transform.eulerAngles = new Vector3(0, 180, 0);
            }
        }
        this.transform.Translate(new Vector3(moveSpeed / 100, 0, 0));
    }
}
