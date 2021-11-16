using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public LayerMask buttonLayer;
    public float radius;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && Physics.CheckSphere(this.transform.position,radius,buttonLayer))
        {
            Collider[] col = Physics.OverlapSphere(this.transform.position, radius, buttonLayer);

            foreach (var item in col)
            {
                InteractiveButton button;
                if (item.TryGetComponent(out button))
                {
                    button.OpenDoor();
                    break;
                }
            }
        }
    }
}
