using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonDialogue : MonoBehaviour
{
    
    public GameObject dialogueBox; 
    public GameObject playerInventoryToggle; 
    public DialogueTrigger[] dragonConversations; 
    public List<int> transferedItemIDs; 

    // Start is called before the first frame update
    void Start()
    {
        dialogueBox.SetActive(false);  
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogueBox.GetComponent<DialogueManager>().conversationFinished){
            playerInventoryToggle.SetActive(true); 
        }
        
    }
}
