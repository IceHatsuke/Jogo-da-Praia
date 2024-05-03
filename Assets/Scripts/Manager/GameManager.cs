using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public static GameManager gameManager;
  public bool aspiradorHand;
  public int moeda = 0;
  public int score = 0;
  public int lixoColetado = 0;
  void Awake()
  {
    gameManager = this;
  }
  void Start()
  {
    aspiradorHand = false;
  }
}
