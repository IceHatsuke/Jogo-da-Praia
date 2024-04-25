using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaObjeto : MonoBehaviour
{   
    public GameObject objeto1Ativar;
    public GameObject objeto1Desativar;
    public GameObject objeto2Ativar;
    public GameObject objeto2Desativar;

    private bool primeiroAtivo = true;

    public void TrocarObjetos()
    {
        primeiroAtivo = !primeiroAtivo; // Inverte o estado atual

        // Troca o primeiro par de objetos
        objeto1Ativar.SetActive(primeiroAtivo);
        objeto1Desativar.SetActive(!primeiroAtivo);

        // Troca o segundo par de objetos
        objeto2Ativar.SetActive(primeiroAtivo);
        objeto2Desativar.SetActive(!primeiroAtivo);
    }
}
