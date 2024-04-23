using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TrocaItensNPC : MonoBehaviour
{

    PlayerRigidbody playerRB;
    public int pontosPorLixo = 10;
    public int moedasPorLixo = 1;

    public TextMeshProUGUI coletaLixo;
    public TextMeshProUGUI moedas;


    public void trocarLixoPorMoedas()
    {

        if(PlayerRigidbody.lixoColetado      != 0)
        {
            int quantidadeMoedas = 1;
            PlayerRigidbody.lixoColetado -= 1; // Atualiza a quantidade de lixo restante
            Debug.Log("AQUI");
            playerRB.AddMoedas(quantidadeMoedas);

            //coletaLixo.text = " " + PlayerRigidbody.score.ToString();
            // moedas.text = " " + playerRB.GetMoedas().ToString();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GameObject.FindWithTag("Player").GetComponent<PlayerRigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
