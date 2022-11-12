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
    public int convoProgress;  

    // Start is called before the first frame update
    void Start()
    {
        giftNum = 0;
        dialogueBox.SetActive(false); 
        convoProgress = 0; 
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogueBox.GetComponent<DialogueManager>().conversationFinished &&(convoProgress != 4)){
        
            inventoryOptionButton.SetActive(true);
            noItemOption.SetActive(true); 

           
        }
        else {
            inventoryOptionButton.SetActive(false);
            noItemOption.SetActive(false); 
        }

        if(giftNum < (0.5*giftTotal)){
            convoProgress = 1; 

        } else if(giftNum == giftTotal){
            convoProgress = 3; 
        }
        else if (giftNum > giftTotal){
            convoProgress = 4; 
        }
        else{
            convoProgress = 2; 
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
    }

    public void NoGiftOption(){
        convoProgress = -2; 
        StartConvo(convoProgress);
         
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
