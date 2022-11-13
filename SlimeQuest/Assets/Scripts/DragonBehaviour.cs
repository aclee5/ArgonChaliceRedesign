using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonBehaviour : Character
{
    public int giftNum; 
    public int giftTotal; 
    public DialogueTrigger introTrigger; 
    public DialogueTrigger exitTrigger; 
    public DialogueTrigger returnTrigger; 
    public DialogueTrigger NotEnoughTrigger; 
    public DialogueTrigger CloseTrigger;
    public DialogueTrigger ExceedingTrigger; 
    public GameObject dialogueBox; 
    public GameObject inventoryOptionButton;
    public GameObject noItemOption;
    public GameObject endButton; 
    public int convoProgress;  
    private bool exit; 
    private bool getEndButton; 

    // Start is called before the first frame update
    void Start()
    {
        giftNum = 0;
        dialogueBox.SetActive(false); 
        convoProgress = 0; 
        exit = false; 
        getEndButton = false; 
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogueBox.GetComponent<DialogueManager>().conversationFinished &&(convoProgress != 4)&& (!exit)){
            if(FindObjectOfType<Player>().dragonItemNum != 0){
                inventoryOptionButton.SetActive(true);
            }
            
            noItemOption.SetActive(true); 
           
        }
        else {
            inventoryOptionButton.SetActive(false);
            noItemOption.SetActive(false); 
        }
        if(dialogueBox.GetComponent<DialogueManager>().conversationFinished && convoProgress == -2){
            convoProgress = -3; 
           
        }
        if(giftNum < (0.5*giftTotal)){
            convoProgress = 1; 

        } else if(giftNum == giftTotal){
            convoProgress = 3; 
        }
        else if (giftNum > giftTotal){
            convoProgress = 4; 
            getEndButton = true; 
        }
        else{
            convoProgress = 2; 
        }

        if(getEndButton && dialogueBox.GetComponent<DialogueManager>().conversationFinished){
            endButton.SetActive(true); 
        }

        if(dialogueBox.GetComponent<DialogueManager>().conversationFinished && exit){
            FindObjectOfType<SaveSystem>().SavePlayerDataTo(2); 
            FindObjectOfType<GameManager>().loadScene(0);
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Player") == true){
            dialogueBox.SetActive(true); 
            introTrigger.StartDialogue();
            

        }
        
    }

    public void GiftToDragon(){
        giftNum ++; 
        FindObjectOfType<Player>().dragonItemNum --; 
    }

    public void NoGiftOption(){
        convoProgress = -2; 
        StartConvo(convoProgress);
        exit = true; 
         
    }

    public void InventoryOption(){
        StartConvo(convoProgress); 
    }

    public void StartConvo(int num){
        switch (num)
        {
            case -2:
                exitTrigger.StartDialogue();
                break; 
            case 1:
                NotEnoughTrigger.StartDialogue();
                break; 
            case 2:
                CloseTrigger.StartDialogue();
                break; 
            case 3:
                ExceedingTrigger.StartDialogue(); 
                break; 
        }
    }




}
