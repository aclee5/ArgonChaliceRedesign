using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonDialogue : Character
{
    
    public GameObject dialogueBox; 
    public GameObject playerInventoryToggle; 
    public GameObject playerBag; 
    public DialogueTrigger[] dragonConversations; 
    public int conversationProgress; 
    private int ingredientNum; 
    public GameObject potion; 
    public GameObject nextButton; 


    // Start is called before the first frame update
    void Start()
    {
        dialogueBox.SetActive(false);
        conversationProgress = 0;
        ingredientNum = 0; 
        potion.SetActive(false);
        nextButton.SetActive(false); 
    

        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogueBox.GetComponent<DialogueManager>().conversationFinished && ingredientNum < 3){
            playerInventoryToggle.SetActive(true); 


        }
        else{
            playerBag.SetActive(false); 
            playerInventoryToggle.SetActive(false); 
        }

        if (ingredientNum == 3 && conversationProgress == 1){
            Debug.Log("Access"); 
            dragonConversations[8].StartDialogue(); 
            conversationProgress = 2; 

         }

         if(conversationProgress == 2 && dialogueBox.GetComponent<DialogueManager>().conversationFinished){
            potion.SetActive(true);
            dragonConversations[9].StartDialogue();
            conversationProgress = 3;  
         }

        if(conversationProgress == 3 && dialogueBox.GetComponent<DialogueManager>().conversationFinished){
            nextButton.SetActive(true); 
        }


      
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            dialogueBox.SetActive(true); 
            dragonConversations[0].StartDialogue();
            conversationProgress = 1; 
    
            
            

        }
        if(collision.GetComponent<PickupInv>() != null){
            int ingredientValue = collision.GetComponent<PickupInv>().itemID; 
            if(conversationProgress > 0 && dialogueBox.GetComponent<DialogueManager>().conversationFinished && ingredientNum < 3){
                Destroy(collision.gameObject); 
                Debug.Log("isBeingDestroyed"); 
                dragonConversations[ingredientValue + 1].StartDialogue();
                ingredientNum +=1; 
                Debug.Log(ingredientNum);                 
            }
        }
    }


}
