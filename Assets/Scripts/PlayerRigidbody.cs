using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerRigidbody : MonoBehaviour
{
    public float velocidade = 10f;
    public static int lixoColetado = 10;

    public static int moeda = 0;
    
    public static bool podeMover = true;


    public static int score = 10;

    private Rigidbody rb;

    public TextMeshProUGUI coletaLixo;
    public TextMeshProUGUI canvas_Moedas;
    private PlayerRigidbody scoreManager;
    private bool isTouchingItem = false;
    private ColetaItens currentItem;



    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
        scoreManager = GetComponent<PlayerRigidbody>();
        // canvas_Moedas = GameObject.Find("Canvas").transform.Find("Textocanvas_Moedas").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {

       if(podeMover == false)
       {
            return;
       }

        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        
        Vector3 movimento = new Vector3(moveHorizontal, 0f, moveVertical) * velocidade * Time.deltaTime;

      
        rb.MovePosition(rb.position + transform.TransformDirection(movimento));
        

        // Verifica se o jogador toca na tela
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            // Se o jogador est� colidindo com um item e toca na tela, coleta o item
            if (isTouchingItem && currentItem != null)
            {
                CollectItem();
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
       
        // Verifica se o personagem est� colidindo com um item
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
         Debug.Log("ERRO");
        // Adiciona pontos ao score manager
        score += currentItem.points;
        coletaLixo.text = "" + score.ToString();

         moeda++;
        // Atualiza o texto das canvas_Moedas na interface do usuário
        canvas_Moedas.text = "canvas_Moedas: " + canvas_Moedas.ToString();

        // Destroi o item
        Destroy(currentItem.gameObject);

        // Redefine o indicador e a refer�ncia ao item atual
        isTouchingItem = false;
        currentItem = null;
    }

    public void AddMoedas(int quantidade)
    {
        moeda = moeda + quantidade; // Adiciona a quantidade de canvas_Moedas especificada
        Debug.Log("Chamou");
        // Atualiza o texto das canvas_Moedas na interface do usuário
        canvas_Moedas.text = moeda.ToString();
        Debug.Log("Chamou22");
    }

    public int Getcanvas_Moedas() // Método para retornar a quantidade de canvas_Moedas
    {
        return moeda;
    }
}