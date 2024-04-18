using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;  // Pontuação inicial

    // Método para adicionar pontos
    public void AddPoints(int points)
    {
        score += points;
        Debug.Log("Pontuação: " + score);
        // Você pode adicionar lógica para atualizar a pontuação na interface do usuário aqui
    }
}
