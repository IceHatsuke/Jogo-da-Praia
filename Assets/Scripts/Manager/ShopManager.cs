using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public static ShopManager shopManager;
    public int moedasPorLixo = 1; 
    void Awake()
    {
        shopManager = this;
    }
}
