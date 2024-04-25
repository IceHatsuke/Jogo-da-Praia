using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao : MonoBehaviour
{
    public GameObject botaoFechar;
    public GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    public void ClicarParaFechar()
    {
        PlayerRigidbody.podeMover = true;
        botaoFechar.SetActive(false);
    }
}
