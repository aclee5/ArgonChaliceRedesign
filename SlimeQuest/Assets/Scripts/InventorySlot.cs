using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public int i; 
    private Inventory inventory;
    void Start(){
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); 
    }

    void Update(){
        if(transform.childCount <= 0){
            inventory.isFull[i] = false; 

        }


    }

    
    public void DropItem(){
        foreach(Transform child in transform){
            GameObject.Destroy(child.gameObject); 
        }
    }
}
