using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaObjeto : MonoBehaviour
{   
    public GameObject objeto1;
    public GameObject objeto2;

    private bool objeto1Ativo = true;

    public void TrocarObjetos()
    {
        objeto1Ativo = !objeto1Ativo; // Inverte o estado atual

        objeto1.SetActive(objeto1Ativo);
        objeto2.SetActive(!objeto1Ativo);
    }
}
