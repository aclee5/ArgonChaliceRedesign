using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonBehaviour : Character
{
    public int giftNum; 
    private int giftTotal; 
    public DialogueTrigger introTrigger; 
    public GameObject dialogueBox; 
    public GameObject inventoryOptionButton;
    public GameObject noItemOption; 

    // Start is called before the first frame update
    void Start()
    {
        giftNum = 0;
        dialogueBox.SetActive(false); 
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogueBox.GetComponent<DialogueManager>().conversationFinished){
            inventoryOptionButton.SetActive(true);
            noItemOption.SetActive(true); 
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Player") == true){
            dialogueBox.SetActive(true); 
            introTrigger.StartDialogue();

        }
        
    }
}
