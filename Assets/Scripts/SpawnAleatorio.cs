using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAleatorio : MonoBehaviour
{
    public GameObject spritePrefab; 
    public int quantidadeSprites = 10; 
    public float raioSpawn = 10f; 

    void Start()
    {
       
        for (int i = 0; i < quantidadeSprites; i++)
        {
            
            Vector3 posicaoSpawn = Random.insideUnitSphere * raioSpawn;
            posicaoSpawn.y = 0f; 

           
            Instantiate(spritePrefab, posicaoSpawn, Quaternion.identity);
        }
    }
}
