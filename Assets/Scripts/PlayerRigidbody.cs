using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRigidbody : MonoBehaviour
{
    public float velocidade = 10f;

    private int score = 0;

    private Rigidbody rb;

    private PlayerRigidbody scoreManager;
    private bool isTouchingItem = false;
    private ColetaItens currentItem;


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

    public void AddPoints(int points)
    {
        score += points;
        Debug.Log("Pontuação: " + score);
        // Você pode adicionar lógica para atualizar a pontuação na interface do usuário aqui
    }
}