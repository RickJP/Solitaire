﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{

    private Solitaire solitaire;

    // Start is called before the first frame update
    void Start()
    {
        solitaire = FindObjectOfType<Solitaire>();
    }

    // Update is called once per frame
    void Update()
    {
        GetMouseClick();
    }

    void GetMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -10));
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider.CompareTag("Deck"))
            {
                // clicked deck
                Deck();
            }
            else if (hit.collider.CompareTag("Card"))
            {
                // clicked card
                Card();
            }

            else if (hit.collider.CompareTag("Top"))
            {
                // clicked card
                Top();
            }
            else if (hit.collider.CompareTag("Bottom"))
            {
                // clicked card
                Bottom();
            }
        }
    }

    void Deck()
    {
        print("Clicked Deck");
        solitaire.DealFromDeck();
    }

    void Card()
    {
        print("Clicked Card");
    }

    void Top()
    {
        print("Clicked Top");
    }

    void Bottom()
    {
        print("Clicked Bottom");
    }
}
