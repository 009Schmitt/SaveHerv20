using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemyDie : MonoBehaviour
{
    public LayerMask mask;
    public float sizeX, sizeY, sizeZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Physics.CheckBox(this.transform.position, new Vector3(sizeX / 2, sizeY / 2, sizeZ / 2), new Quaternion(), mask))
        //{
        //    Destroy(this);
        //}
    }

    public void KillEnemy()
    {
        Destroy(gameObject);
    }
}
