using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public LayerMask maskEnemy,mask;
    public GameObject bullet;
    public float pierce;
    // Start is called before the first frame update
    void Start()
    {
        pierce = FindObjectOfType<PlayerController>().pierceShot;
    }

    // Update is called once per frame
    void Update()
    {

        Collider[] col = Physics.OverlapSphere(this.transform.position, .12f, maskEnemy);

        if (col.Length > 0)
        {
            NormalEnemyDie die;
            if (col[0].TryGetComponent(out die))
            {
                die.KillEnemy();
                pierce--;
                if (pierce == 0)
                {
                    Destroy(bullet);

                }
            }
        }
        else if (Physics.CheckSphere(this.transform.position, .11f, mask))
        {
            Destroy(bullet);
        }


    }
}
