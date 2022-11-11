using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickupInv : MonoBehaviour
{
    private Inventory inventory;
     public GameObject itemButton;
 

    // Start is called before the first frame update
    void Start()
    {   
        
       
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

  

    //method that will handle collisions with ingredients objects 
    private void OnTriggerEnter2D(Collider2D collider){
      
        //checks if item is a potion ingredient and adds to counter 
        if(collider.CompareTag("Player")){
            //enable text 
            
           

            for(int i=0; i<inventory.slots.Length; i++){
                if(inventory.isFull[i] == false){
                    //item can be added to inventory
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
       
        }
        
        
    }

}
