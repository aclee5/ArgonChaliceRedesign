using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IngredientCounter : MonoBehaviour
{
    public Player player; 
    //text object for ingredient counter 
    public TMP_Text ingredientCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ingredientCounter.text = "Ingredients Collected: " + player.ingredientNum + "/3";
    }
}
