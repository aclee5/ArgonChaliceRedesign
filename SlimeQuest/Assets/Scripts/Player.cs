using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : Character
{
     //int to look after the amount of ingredients 
    public int ingredientNum;
    public int dragonItemNum; 

   
    
    //inventory stuff 
    //private Inventory inventory;
   // public GameObject itemButton;

    // Start is called before the first frame update
    void Start()
    {
        ingredientNum = 0;
        dragonItemNum = 0; 
          
        if (string.IsNullOrEmpty(characterName)){
            characterName = "Player"; 
        }
        //inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     //method that will handle collisions with ingredients objects 
    private void OnTriggerEnter2D(Collider2D collider){

        //checks if item is a potion ingredient and adds to counter 
        if(collider.CompareTag("PotionIngredient")){
            ingredientNum +=1;
        }
        if(collider.CompareTag("DragonItem")){
            dragonItemNum +=1;
        }

        // for(int i=0; i<inventory.slots.Length; i++){
        //     if(inventory.isFull[i] == false){
        //         //item can be added to inventory
        //         inventory.isFull[i] = true;
        //         Instantiate(itemButton, inventory.slots[i].transform, false);
        //         break;
        //     }
        // }
       

        
        //Destroy(collider.gameObject);
    }
}
 