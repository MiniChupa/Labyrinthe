using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool canOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if(canOpen)
        {
            GetComponent<Animator>().enabled = true;
        }
    }
}
