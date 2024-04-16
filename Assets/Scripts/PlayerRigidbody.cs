using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRigidbody : MonoBehaviour
{
    public float velocidade = 10f; 
    
  

    private Rigidbody rb;
    

    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        
        Vector3 movimento = new Vector3(moveHorizontal, 0f, moveVertical) * velocidade * Time.deltaTime;

      
        rb.MovePosition(rb.position + transform.TransformDirection(movimento)); 
        
    }
}