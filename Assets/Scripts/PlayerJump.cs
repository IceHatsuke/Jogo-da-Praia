using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float forcaPulo = 5f; 

    private Rigidbody rb; 
    private bool podePular = true; 

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && podePular)
        {
           
            rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
            
            podePular = false;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        podePular = true;
    }
}
