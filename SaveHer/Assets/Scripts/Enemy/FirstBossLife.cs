using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBossLife : MonoBehaviour
{
    public float life;
    public GameObject flag;
    public GameObject[] bossParts; 

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage()
    {
        life--;
        if (life < 1)
        {
            foreach (var item in bossParts)
            {
                Destroy(item);
            }
            flag.SetActive(true);
        }

    }


}
