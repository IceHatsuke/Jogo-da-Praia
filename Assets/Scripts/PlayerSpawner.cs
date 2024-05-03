using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
 
    public Transform playerPrefab;
    public Transform spawnLocation;

    //Singleton
    public static PlayerSpawner instance;

    public void Awake()
    {
        //instancia = transform.GetComponent<PlayerSpawner>()
        instance = this;
    }
    public void Spawn()
    {
        Transform playerCriado = Instantiate(playerPrefab);
        playerCriado.transform.position = spawnLocation.transform.position;
    }

}