using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            GameObject.Find("ExitPoint").GetComponent<DoorScript>().canOpen = true;
            Destroy(transform.parent.gameObject);
        }
    }
}
