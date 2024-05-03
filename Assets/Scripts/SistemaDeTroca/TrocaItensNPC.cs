using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TrocaItensNPC : MonoBehaviour
{

    public void trocarLixoPorMoedas()
    {

        if(PlayerRigidbody.lixoColetado != 0)
        {
            GameManager.gameManager.moeda++;

            GameManager.gameManager.lixoColetado -= 1; // Atualiza a quantidade de lixo restante
            Debug.Log("AQUI");
        }
    }

}
