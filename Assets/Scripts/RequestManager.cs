using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class Usuario
{
    public int id;
    public string nome;
    public int pontos;
    public string created_at;
}

public class RequestManager : MonoBehaviour
{
    static string apiUrl = "https://mqftychgxsnwvpqfmgmc.supabase.co/rest/v1/JogoDaPraia";
    static string apiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Im1xZnR5Y2hneHNud3ZwcWZtZ21jIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MTI1OTgyNDIsImV4cCI6MjAyODE3NDI0Mn0.XwBwQ-den_9zPcE9YkW6HyePVLYFij1GWwSU7hpztY0";

    //Buscar o usuario pelo nome
    public static async Task<Usuario> BuscaUsuario(string nome)
    {

        //interpolar (adicionar variaveis no texto)
        string requestUrl = $"{apiUrl}?nome=eq.{nome}&apikey={apiKey}";

        UnityWebRequest request = UnityWebRequest.Get(requestUrl);
        await request.SendWebRequest();

        string response = request.downloadHandler.text;

        if(response == "[]")
        {
            return null;
        }    
           

        List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(response);

        Debug.Log(usuarios[0].id);

        return usuarios[0];
       

    }


    //Criar novo usuario

    public static async Task<Usuario> CriarUsuario(string nome)
    {
        string requestUrl = $"{apiUrl}?apikey={apiKey}";

        string json = $" \"nome\":\"{nome}\", \"pontos\": 0 ";
        json = "{" + json + "}";

         UnityWebRequest request = UnityWebRequest.Post(requestUrl, json, "application/json");
        await request.SendWebRequest();

        return await BuscaUsuario(nome);

    }

    //GET, POST, PUT, DELETE

    //Atualizar pontos buscando pelo nome do usuario
    //Buscar todos os usuarios

    

}
