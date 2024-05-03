using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDController : MonoBehaviour
{

    public TMP_InputField inputNome;

    //Singleton
    public static HUDController instancia;
    public GameObject hud;   
    public GameObject hudPontos;

    

    private void Awake()
    {
        instancia = this;       
    }

    public async void BotaoEntrar()
    {

       
        Usuario usuario = await RequestManager.BuscaUsuario(inputNome.text);

        if(usuario == null) //cadastrar
        {
            usuario = await RequestManager.CriarUsuario(inputNome.text);
        }

        
        hud.SetActive(false);
        hudPontos.SetActive(true);
       
       //Player já está logado, bora criar ele e spawnar os pontos
       PlayerSpawner.instance.Spawn();
       //GameObject.Find("Spawn").GetComponent<SpawnerController>().Spawnar();

        //RequestManager.BuscaUsuario(inputNome.text);
    }

}
