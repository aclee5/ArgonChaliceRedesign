using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveTiles : MonoBehaviour
{
    public SpriteRenderer sr;
    public Color colorA = Color.red;
    public Color colorB = Color.black;
    private int size;

    public int[] correctArray = {3,4,1,2}; // fix order later
    public int[] playerArray; 

    // Start is called before the first frame update
    void Start()
    {
        size = 0;
        sr = GameObject.Find("Square").GetComponent<SpriteRenderer>();
        //playerArray = new int[4]; 
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnTriggerEnter2D(Collider2D collider){
        Debug.Log("testing ");
        sr.color = colorB;
        //playerArray[0] =3;
        //
        //here can test if the correct square is triggered and change its colour 
        //if statements to check which square they hit 
        
        

        if(collider.CompareTag("Red")) {
            //red square value is 3 
            playerArray[0] =3;
            Debug.Log("player: " + playerArray[0]);
        } 
        
    }
    public void OnTriggerExit2D(Collider2D collider){
        Debug.Log("exited");
        //sr.color = colorA;
    }
}
