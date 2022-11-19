using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Riddles : MonoBehaviour

{
    public DialogueTrigger trigger;

    public DialogueTrigger riddle2Trigger;
    public DialogueTrigger riddle3Trigger;
    public GameObject dialogueBox; 
    public GameObject answerOneButton;
    public GameObject answerTwoButton;
    public GameObject answerThreeButton;

    //riddle 2 
    public GameObject answerOneButton2;
    public GameObject answerTwoButton2;
    public GameObject answerThreeButton2;

    //riddle 3 
    public GameObject answerOneButton3;
    public GameObject answerTwoButton3;
    public GameObject answerThreeButton3;

    public bool correctRiddle; // to check if they correctly did riddle 
    public bool correctRiddle2;
    public bool correctRiddle3;
    public int convoProgress;

    
    //texts for the buttton blobbs

   
    void Start(){
        //Debug.Log("hi");
       correctRiddle = false;
       correctRiddle2 = false;
       convoProgress = 0;
       answerOneButton.SetActive(false);
       answerThreeButton.SetActive(false);
       answerTwoButton.SetActive(false);
       answerOneButton2.SetActive(false);
       answerThreeButton2.SetActive(false);
       answerTwoButton2.SetActive(false);
        answerOneButton3.SetActive(false);
       answerThreeButton3.SetActive(false);
       answerTwoButton3.SetActive(false);
       
    }

    void Update(){
        // if(correctRiddle){
        //    // Debug.Log("answer correct");
        //     convoProgress =1;
            
        // } if(correctRiddle2){
        //     convoProgress = 2;
        // }

        if(dialogueBox.GetComponent<DialogueManager>().conversationFinished){
           
            answerOneButton.SetActive(true);
            answerTwoButton.SetActive(true);
            answerThreeButton.SetActive(true);

        } 
        
        else {
            correctRiddle=false;
            answerOneButton.SetActive(false);
            answerTwoButton.SetActive(false);
            answerThreeButton.SetActive(false);
        }

        if(dialogueBox.GetComponent<DialogueManager>().conversationFinished && convoProgress == 1){
           // Debug.Log("testing");
            answerOneButton2.SetActive(true);
            answerTwoButton2.SetActive(true);
            answerThreeButton2.SetActive(true);
        } else {
            answerOneButton2.SetActive(false);
            answerTwoButton2.SetActive(false);
            answerThreeButton2.SetActive(false);
        }
        if(dialogueBox.GetComponent<DialogueManager>().conversationFinished && convoProgress == 2){
            Debug.Log("testing 3");
            answerOneButton3.SetActive(true);
            answerTwoButton3.SetActive(true);
            answerThreeButton3.SetActive(true);
        } else {
            answerOneButton3.SetActive(false);
            answerTwoButton3.SetActive(false);
            answerThreeButton3.SetActive(false);
        }

        Debug.Log("convo " + convoProgress);
    }

    public GameObject dialogueBox; 
    // Start is called before the first frame update
    void Start(){
            dialogueBox.SetActive(true); 
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
        convoProgress = 1;
        correctRiddle = true; 
        StartConvo(convoProgress);
        
        //answerOneButton.SetActive(false);
    
    }

    public void answerTwo2(){
        correctRiddle=false;
        correctRiddle2 = true;
        convoProgress = 2;
        StartConvo(convoProgress);
    }

    public void answerThree3(){
        correctRiddle2 =false;
        correctRiddle3 = true;
        StartConvo(convoProgress);
    }

    public void StartConvo(int num){
        switch (num)
        {
            case 1:
                correctRiddle = false;
            
                riddle2Trigger.StartDialogue();
                
                //answerOneButton.GetComponentInChildren<Text>().text = "testing";
                break; 
            case 2:
                correctRiddle2 = false;
                riddle3Trigger.StartDialogue();
                break;
        }
}

