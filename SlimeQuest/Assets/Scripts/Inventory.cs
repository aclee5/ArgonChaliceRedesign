using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour

{
    // public int slotsAvailiable; 
    public bool[] isFull;
    public GameObject[] slots;
    public List<int> itemIDs; 
    public GameObject[] items; 

    // Start is called before the first frame update
    void Awake(){
       
        
    }
    void Start()
    {
      
            for(int i=0; i < itemIDs.Capacity; i++){
                if(i < slots.Length){
                    int id = itemIDs[i];
                    PickupInv item = items[id].GetComponent<PickupInv>(); 
                    Instantiate(item.itemButton, slots[i].transform, false); 
                    Debug.Log("instantiated item " + items[id]+  " at slot" + slots[i]);

                }               

            }

        
           

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
