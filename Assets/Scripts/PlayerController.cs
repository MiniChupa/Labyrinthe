using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 4.0f, rot = 80f, currSpeed;


    private Vector3 deplacement = Vector3.zero;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
       

        if(Input.GetKey(KeyCode.LeftControl))
        {
            currSpeed = speed * 2;
        } else
        {
            currSpeed = speed;
        }

        transform.Rotate(Vector3.up * rot * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        float goForward = Input.GetAxis("Vertical");
        if(goForward > 0)
        {
            transform.Translate(Vector3.forward * currSpeed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
        }
        
    }
}
