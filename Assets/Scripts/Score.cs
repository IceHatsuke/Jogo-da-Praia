using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;  // Pontua��o inicial

    // M�todo para adicionar pontos
    public void AddPoints(int points)
    {
        score += points;
        Debug.Log("Pontua��o: " + score);
        // Voc� pode adicionar l�gica para atualizar a pontua��o na interface do usu�rio aqui
    }
}
