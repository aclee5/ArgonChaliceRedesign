using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riddles : MonoBehaviour

{
    public DialogueTrigger trigger;
    public DialogueTrigger riddle2Trigger;

    public GameObject dialogueBox; 
    public GameObject answerOneButton;
    public bool correctRiddle; // to check if they correctly did riddle 
    public int convoProgress;
   
    void Start(){
        //Debug.Log("hi");
       correctRiddle = false;
       convoProgress = 0;
       answerOneButton.SetActive(false);
    }

    void Update(){
        if(correctRiddle){
            Debug.Log("answer correct");
            convoProgress =1;
            
        }

        if(dialogueBox.GetComponent<DialogueManager>().conversationFinished ){
           
                answerOneButton.SetActive(true);
            
           
        } else {
            answerOneButton.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            dialogueBox.SetActive(true);
            //answerOneButton.SetActive(true);  
            trigger.StartDialogue(); 
            
        }
    }

    void OnTriggerExit2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            dialogueBox.SetActive(false); 
        }
    }

    public void answerOne(){
        //method to deal with option 1
        Debug.Log("pressed option 1");
        //correct asnwer 
        correctRiddle = true; 
        StartConvo(convoProgress);
        //answerOneButton.SetActive(false);
    
    }


    public void StartConvo(int num){
        switch (num)
        {
            case 1:
                riddle2Trigger.StartDialogue();
                break; 
            
        }
}
}
