using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBossLifeBar : MonoBehaviour
{
    public FirstBossLife life;
    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3((15* life.life) / 50, 1, .2f);
    }
}
