using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveTiles : MonoBehaviour
{
    public SpriteRenderer sr, sr2, sr3, sr4, sr5;
    public Color colorRed = Color.red;
    public Color colorBlack = Color.black;
    public Color colorBlue = Color.blue;
    public Color colorGreen = Color.green;
    public Color colorYellow = Color.yellow;
    
    private int size;

    //public int[] correctArray = {3,4,1,2}; // fix order later
    //public int[] playerArray; 
    
    ArrayList playerArray2 = new ArrayList();
    ArrayList correctArray = new ArrayList(new string[] {"3","4","1","2"});

    // Start is called before the first frame update
    void Start()
    {
        size = 0;
        //Debug.Log("start: " +playerArray.Length);
     
        sr2 = GameObject.Find("RedSquare").GetComponent<SpriteRenderer>();
        sr3 = GameObject.Find("GreenSquare").GetComponent<SpriteRenderer>();
        sr4 = GameObject.Find("BlueSquare").GetComponent<SpriteRenderer>();
        sr5 = GameObject.Find("YellowSquare").GetComponent<SpriteRenderer>();
        //playerArray = new int[4]; 
        
    }

    // Update is called once per frame
    void Update()
    {
    //    foreach(int i in playerArray2){
    //          Debug.Log(i);
             
    //         //size++;
        
    //     }
        
       // Debug.Log("stesting euqals " + playerArray2.Equals(correctArray)); // does not actaully work LOL 
        
        
        
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
        // Debug.Log("count of array: " + playerArray2.Count);
        // //if(playerArray2.Count == 4){
        //     for(int i=0; i< playerArray2.Count; i++){
        //       Debug.Log("i: " + playerArray2[i] + " correct i : " + correctArray[i]);
        //       if(playerArray2[i] == correctArray[i] )
        //       {
                
        //             Debug.Log("they are same");
        //             sr2.color = colorBlack;
        //         }
        //         else {
        //           Debug.Log(" else i: " + playerArray2[i] + " correct and i : " + correctArray[i]);
        //           Debug.Log("NOT THE SAME "); // always thinks they arent the same even when its literally the same omfg
        //         }

        //     }
        int counterTime = 0;
       // if(startCompare == true){
          foreach(string i in correctArray)
        {
          foreach(string j in playerArray2) 
          {
            if(i == j ) 
            {
              Debug.Log("wow omg " + i + j);
              counterTime+=1;

              if(counterTime == 1 || counterTime == 0 && i == "3")
              {
                Debug.Log("got here " +counterTime);
                sr2.color = colorBlack;
              }
              else if(counterTime == 2 && i == "4")
              {
                  sr3.color = colorBlack;
              } 
              else if (counterTime == 3 && i == "1"){
                sr4.color = colorBlack;
              } 
              else if(counterTime == 4 && i == "2")
              {
                sr5.color = colorBlack;
              }
              else {
                sr2.color = colorRed;
                sr3.color = colorGreen;
                sr4.color = colorBlue;
                sr5.color = colorYellow;
                //counterTime = 0;
                //break;
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
        //}
        

        // foreach(string i in playerArray2){
        //   if(i == "3") {
        //     Debug.Log("just my luck");
        //     sr2.color = colorBlack;
            
        //   }if(i == "4"){
        //       Debug.Log("yes 2");
        //       sr3.color = colorBlack;
        //     }
          
        //   else {
        //     Debug.Log("SHIT");
        //     //sr2.color = colorRed;
        //       //  sr3.color = colorGreen;
        //   }
        // }
        //}

        // for(int i=0; i< playerArray2.Count; i++){
        //     // size++; // not accurate but the .Count is 
        //     // Debug.Log("Size of array: " + size);
           
        //     for(int j =0; j<correctArray.Count; j++){
        //         //Debug.Log("test " + correctArray[j]);
        //         Debug.Log("i: " + playerArray2[i] + "j: " + correctArray[j]);
        //         if(playerArray2[i] == correctArray[j] ){
                
        //             Debug.Log("they are same");
        //         }
        //         else{
        //           Debug.Log("NOT THE SAME ");
        //         }
        //     }
        // }
         

        // foreach(int i in correctArray){
        //     foreach(int j in playerArray2){
        //         if(i == j){
        //             Debug.Log("IT WORKED : D");
        //             sr2.color = colorBlack;
        //         } else {
        //             Debug.Log("nope");
        //             sr2.color = colorRed;
        //             // sr3.color = colorGreen;
        //             // sr4.color = colorBlue;
        //             // sr5.color = colorYellow;
        //         }
        //     }
        // }
        

        

      
    }
    public void OnTriggerExit2D(Collider2D collider){
        Debug.Log("exited");
        //sr.color = colorA;
        
    }
}
