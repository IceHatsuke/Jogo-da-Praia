using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrocaItem : MonoBehaviour
{

    public Sprite spriteNormal;
    public Sprite spriteTroca;

    private bool spriteTrocado = false;

    private SpriteRenderer spriteRenderer;

    public Button botaoTrocar;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = spriteNormal;
        botaoTrocar.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    /*void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (spriteTrocado)
            {
                spriteRenderer.sprite = spriteNormal;
                spriteTrocado = false;
            }
            else
            {
                spriteRenderer.sprite = spriteTroca;
                spriteTrocado = true;

            }

            if (spriteTrocado)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
                GameObject.FindGameObjectWithTag("OutroSprite").GetComponent<SpriteRenderer>().enabled = false;
            }
            else
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("OutroSprite").GetComponent<SpriteRenderer>().enabled = true;
            }

        
    }*/


    //criei OnClick para clicar no botao e trocar para o aspirador
    void OnClick()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (spriteTrocado)
            {
                spriteRenderer.sprite = spriteNormal;
                spriteTrocado = false;
            }
            else
            {
                spriteRenderer.sprite = spriteTroca;
                spriteTrocado = true;

            }

            if (spriteTrocado)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
                GameObject.FindGameObjectWithTag("OutroSprite").GetComponent<SpriteRenderer>().enabled = false;
            }
            else
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("OutroSprite").GetComponent<SpriteRenderer>().enabled = true;
            }

        }
    }
}
