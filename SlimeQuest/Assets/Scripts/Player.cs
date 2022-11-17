using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : Character
{
     //int to look after the amount of ingredients 
    public int ingredientNum;
    public int dragonItemNum; 
    public List<Vector3> respawnPoints = new List<Vector3>(); 
   
    
    //inventory stuff 
    //private Inventory inventory;
   // public GameObject itemButton;

    // Start is called before the first frame update
    void Awake(){
        ingredientNum = 0;
        dragonItemNum = 0;
        FindObjectOfType<GameHandler>().LoadPlayerData();  

    }
    void Start()
    {
        if(respawnPoints.Capacity-1 >= SceneManager.GetActiveScene().buildIndex){
            transform.position = respawnPoints[SceneManager.GetActiveScene().buildIndex]; 
        }             
          
        if (string.IsNullOrEmpty(characterName)){
            characterName = "Player"; 
        }
        Debug.Log("Position is:" + transform.position); 

        

       
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

    public void SetName(string newName){
        characterName = newName; 
    }

    public void SetIngredientNumber(int num){
        ingredientNum = num; 
    }

    public void SetDragonNumber(int num){
        dragonItemNum = num; 
    }

    public void PlaceCheckPoint(int sceneIndex, Vector3 t){
        respawnPoints[sceneIndex] = t; 
    }
}
 