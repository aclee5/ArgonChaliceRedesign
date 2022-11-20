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

    public GameObject nextSceneTrigger; 
    
    public AudioSource pressTileSound, wrongSound;
    
    
    ArrayList playerArray2 = new ArrayList();
    ArrayList correctArray = new ArrayList(new string[] {"1","2","3","4"});
    

    // Start is called before the first frame update
    void Start()
    {
        

        sr2 = GameObject.Find("RedSquare").GetComponent<SpriteRenderer>();
        sr3 = GameObject.Find("GreenSquare").GetComponent<SpriteRenderer>();
        sr4 = GameObject.Find("BlueSquare").GetComponent<SpriteRenderer>();
        sr5 = GameObject.Find("YellowSquare").GetComponent<SpriteRenderer>();
      
        
    }

    // Update is called once per frame
    void Update()
    {
    

        if((sr2.color == colorBlack) && (sr3.color == colorBlack) && (sr4.color == colorBlack) && (sr5.color == colorBlack)){
          nextSceneTrigger.SetActive(true); 

        }
        

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

              if(counterTime == 1  && i == "1")
              {
                Debug.Log("got here " +counterTime);
                pressTileSound.Play();
                sr4.color = colorBlack;
              }
              else if(counterTime == 2 && i == "2")
              {
                  pressTileSound.Play();
                  sr5.color = colorBlack;
              } 
              else if (counterTime == 3 && i == "3"){
                pressTileSound.Play();
                sr2.color = colorBlack;
              } 
              else if(counterTime == 4 && i == "4")
              {
                pressTileSound.Play();
                sr3.color = colorBlack;
              }
              else {
                wrongSound.Play();
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
