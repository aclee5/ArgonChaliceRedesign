using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveTiles2 : MonoBehaviour
{
    public SpriteRenderer sr, sr2, sr3, sr4, sr5, sr6;
    public Color colorRed = Color.red;
    public Color colorBlack = Color.black;
    public Color colorBlue = Color.blue;
    public Color colorGreen = Color.green;
    public Color colorYellow = Color.yellow;
    public Color colorPurple = new Color(176.0f, 66.0f, 245.0f);
    
    private int size;

    //public int[] correctArray = {3,4,1,2}; // fix order later
    //public int[] playerArray; 
    
    ArrayList playerArray2 = new ArrayList();
    ArrayList correctArray = new ArrayList(new string[] {"2","3","5","4","1"});
    //order - yellow, red purple green blue 

    // Start is called before the first frame update
    void Start()
    {
        size = 0;

        sr2 = GameObject.Find("RedSquare").GetComponent<SpriteRenderer>();
        sr3 = GameObject.Find("GreenSquare").GetComponent<SpriteRenderer>();
        sr4 = GameObject.Find("BlueSquare").GetComponent<SpriteRenderer>();
        sr5 = GameObject.Find("YellowSquare").GetComponent<SpriteRenderer>();
        sr6 = GameObject.Find("PurpleSquare").GetComponent<SpriteRenderer>();
    }
    void Update(){
        //dfsdfs
    }


    public void OnTriggerEnter2D(Collider2D collider){
      
        //here can test if the correct square is triggered and change its colour 
        //if statements to check which square they hit 
    
        bool startCompare = false;
        if(collider.CompareTag("Red")){
             playerArray2.Add("3");
             startCompare = true;
           } 
           if(collider.CompareTag("Green")){
             playerArray2.Add("4");
             startCompare = true;
           } 
           if(collider.CompareTag("Blue")) {
             playerArray2.Add("1");
             startCompare = true;
            
           } 
           if(collider.CompareTag("Yellow")){
             playerArray2.Add("2");
             startCompare =true;
         
           }
           if(collider.CompareTag("Purple")){
            playerArray2.Add("5");
            startCompare=true;
           }

        int counterTime = 0;

//STUPID SHIT NOT WORKIGN 
//THINKS GREEN IS CORRECT WHEN HITS 1 WRONG AND GOING BACK INTO LOOP 

        foreach(string i in correctArray)
        {
          foreach(string j in playerArray2) 
          {
            if(i == j ) 
            {
              Debug.Log("wow omg " + i + j);
              counterTime+=1;

              if(counterTime == 1 && i == "2")
              {
                Debug.Log("got here " +counterTime);
                sr5.color = colorBlack;
              }
              else if(counterTime == 2 && i == "3")
              {
                  sr2.color = colorBlack;
              } 
              else if (counterTime == 3 && i == "5"){
                sr6.color = colorBlack;
              } 
              else if(counterTime == 4 && i == "4")
              {
                sr3.color = colorBlack;
              } else if(counterTime == 5 && i == "1"){
                sr4.color = colorBlack;
              }
              else {
                sr2.color = colorRed;
                sr3.color = colorGreen;
                sr4.color = colorBlue;
                sr5.color = colorYellow;
                sr6.color = colorPurple;
               
                startCompare = false;
                
              }
              
              
            } 
            
          }
        }
        if(startCompare == false) {
          for(int i =0; i< playerArray2.Count; i++){
            playerArray2.Clear();
            counterTime = 0 ;
          }
        }


      
    }
    public void OnTriggerExit2D(Collider2D collider){
        Debug.Log("exited");
        //sr.color = colorA;
        
    }
}
