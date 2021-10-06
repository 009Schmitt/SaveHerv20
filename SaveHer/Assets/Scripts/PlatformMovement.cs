using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public GameObject platform;
    /// <summary>
    /// the less point
    /// </summary>
    public float start;
    /// <summary>
    /// the bigest point
    /// </summary>
    public float end;
    /// <summary>
    /// 1 = x / 2 = y / 3 = z
    /// </summary>
    public int direction;
    public float velocity;

    public bool way;

    void Start()
    {
        way = true;
        //if (direction == 1)
        //{
        //    platform.GetComponent<Rigidbody>().velocity = new Vector3(velocity, 0, 0);
        //}
        //else if (direction == 2)
        //{
        //    platform.GetComponent<Rigidbody>().velocity = new Vector3(0, velocity, 0);
        //}
        //else
        //{
        //    platform.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, velocity);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == 1)
        {
            if (way)
            {
                //platform.GetComponent<Rigidbody>().velocity = new Vector3(velocity, 0, 0);
                platform.transform.Translate(new Vector3(velocity/100, 0, 0));
            }
            else
            {
                //platform.GetComponent<Rigidbody>().velocity = new Vector3(-velocity, 0, 0);
                platform.transform.Translate(new Vector3(-velocity/100, 0, 0));
            }
            if (start > platform.transform.position.x)
            {
                way = true;
            }
            else if (end < platform.transform.position.x)
            {                
                way = false;
            }
        }
        else if (direction == 2)
        {
            if (way)
            {
                //platform.GetComponent<Rigidbody>().velocity = new Vector3(0, velocity, 0);
                platform.transform.Translate(new Vector3(0, velocity/100, 0));
            }
            else
            {
                //platform.GetComponent<Rigidbody>().velocity = new Vector3(0, -velocity, 0);
                platform.transform.Translate(new Vector3(0, -velocity/100, 0));
            }
            if (start > platform.transform.position.y)
            {
                way = true;
            }
            else if (end < platform.transform.position.y)
            {
                way = false;
            }
        }
        else
        {
            if (way)
            {
                //platform.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, velocity);
                platform.transform.Translate(new Vector3(0, 0, velocity/100));
            }
            else
            {
                //platform.GetComponent<Rigidbody>().velocity = new Vector3(0, 0,-velocity);
                platform.transform.Translate(new Vector3(0, 0, -velocity / 100));
            }
            if (start > platform.transform.position.z)
            {
                way = true;
            }
            else if (end < platform.transform.position.z)
            {
                way = false;
            }
        }




    }
}
