using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveButton : MonoBehaviour
{
    public GameObject door,red,green;

    public void OpenDoor()
    {
        if (door.activeInHierarchy)
        {
            door.SetActive(false);
            red.SetActive(false);
            green.SetActive(true);
        }


    }
}
