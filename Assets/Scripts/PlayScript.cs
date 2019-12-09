using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScript : MonoBehaviour
{
    
    public Rigidbody rb;
    public float JumpSpeed = 0.1f;
    public float Forward = 0.05f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)||Input.touchCount>0 && Input.touchCount<2)
        {
            rb.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
            rb.AddForce(Vector3.forward * Forward, ForceMode.Impulse);

        }
        

    }
}
