using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerRigidbody : MonoBehaviour
{
    public float velocidade = 10f;
    public static float lixoColetado = 0;

    
    public VariableJoystick variableJoystick; //variavel joystick



    public int score = 0;

    private Rigidbody rb;

    public TextMeshProUGUI coletaLixo;
    public TextMeshProUGUI moedas;
    private PlayerRigidbody scoreManager;
    private bool isTouchingItem = false;
    private ColetaItens currentItem;



    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
        scoreManager = GetComponent<PlayerRigidbody>();
    }

    void Update()
    {
                
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        
        Vector3 movimento = new Vector3(variableJoystick.Horizontal, 0f, variableJoystick.Vertical) * velocidade * Time.deltaTime;

      
        rb.MovePosition(rb.position + transform.TransformDirection(movimento));

        // Verifica se o jogador toca na tela
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            // Se o jogador está colidindo com um item e toca na tela, coleta o item
            if (isTouchingItem && currentItem != null)
            {
                CollectItem();
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
       
        // Verifica se o personagem está colidindo com um item
        if ( other.transform.parent && other.transform.parent.GetComponent<ColetaItens>() != null)
        {
            isTouchingItem = true;
            currentItem = other.transform.parent.GetComponent<ColetaItens>();
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Se o personagem sai de contato com o item, redefine o indicador
        if (other.GetComponent<ColetaItens>() != null)
        {
            isTouchingItem = false;
            currentItem = null;
        }
    }

    void CollectItem()
    {
        // Adiciona pontos ao score manager
        score += currentItem.points;
        coletaLixo.text = "0" + score.ToString();


        // Destroi o item
        Destroy(currentItem.gameObject);

        // Redefine o indicador e a referência ao item atual
        isTouchingItem = false;
        currentItem = null;
    }
}