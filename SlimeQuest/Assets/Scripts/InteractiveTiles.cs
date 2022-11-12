using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveTiles : MonoBehaviour
{
    public SpriteRenderer sr;
    public Color colorA = Color.red;
    public Color colorB = Color.black;
    private int size;

    //public int[] correctArray = {3,4,1,2}; // fix order later
    //public int[] playerArray; 
    
    ArrayList playerArray2 = new ArrayList();
    ArrayList correctArray = new ArrayList(new int[] {3,4,1,2});

    // Start is called before the first frame update
    void Start()
    {
        size = 0;
        //Debug.Log("start: " +playerArray.Length);
        sr = GameObject.Find("Square").GetComponent<SpriteRenderer>();
        //playerArray = new int[4]; 
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnTriggerEnter2D(Collider2D collider){
        //size +=1; //every time they theorietically enter a tile then the size of array will go up - max sure to cap at somepoint though later 
        Debug.Log("testing ");
        sr.color = colorB;
        //playerArray[0] =3;
        //
        //here can test if the correct square is triggered and change its colour 
        //if statements to check which square they hit 
    

        if(collider.CompareTag("Red")){
             playerArray2.Add(3);
           } 
           if(collider.CompareTag("Green")){
             playerArray2.Add(4);
           } 
           if(collider.CompareTag("Blue")) {
             playerArray2.Add(1);
            
           } 
           if(collider.CompareTag("Yellow")){
             playerArray2.Add(2);
         
           }
        
        // foreach(int i in playerArray2){
        //     Debug.Log(i);
        //     size++;
        // }

        foreach(int i in correctArray){
            foreach(int j in playerArray2){
                if(i == j){
                    Debug.Log("IT WORKED : D");
                } else {
                    Debug.Log("nope");
                }
            }
        }

        Debug.Log("size" + size);
       
        // for(int i =0; i < playerArray2.Length; i++){
        //     Debug.Log(playerArray.ToString());
        // }
        
        //int arrSize = sizeof(playerArray)/sizeof(playerArray[0]);
        // Debug.Log("item test" + playerArray2[0]);
        // Debug.Log("item test2" + playerArray2[1]);
        // Debug.Log("item test3" + playerArray2[2]);
        // Debug.Log("item test4" + playerArray2[3]);
        

        // if(collider.CompareTag("Red")) {
        //     //red square value is 3 
        //     playerArray[0] =3;
        //     Debug.Log("player: " + playerArray[0]);
        // } 
        
    }
    public void OnTriggerExit2D(Collider2D collider){
        Debug.Log("exited");
        //sr.color = colorA;
    }
}
