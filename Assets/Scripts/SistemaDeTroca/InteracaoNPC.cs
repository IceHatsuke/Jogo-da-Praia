using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracaoNPC : MonoBehaviour
{
    public GameObject canvasTroca;
    

    private PlayerRigidbody playerRigidbody; // Referência para o script PlayerController
    private bool playerInside = false; // Verifica se o personagem está dentro da área de interação


    private void Start()
    {
        // Desativa o canvas no início para garantir que não esteja visível inicialmente
        if (canvasTroca != null)
        {
            canvasTroca.SetActive(false);
        }
        
    }



    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o personagem entrou na área de interação com o NPC
        if (other.CompareTag("Player"))
        {
            // Ativa o canvas de troca
            if (canvasTroca != null)
            {
                canvasTroca.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Verifica se o personagem saiu da área de interação com o NPC
        if (other.CompareTag("Player"))
        {
            // Desativa o canvas de troca
            if (canvasTroca != null)
            {
                canvasTroca.SetActive(false);
            }
        }
    }
}

