using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardBehavior : MonoBehaviour
{
    public DialogueTrigger trigger;
    public GameObject dialogueBox; 
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player") && FindObjectOfType<Player>().ingredientNum == 3){
            dialogueBox.SetActive(true); 
            trigger.StartDialogue(); 
            
        }
    }

    void OnTriggerExit2D(Collider2D collision){
        if(collision.CompareTag("Player") && FindObjectOfType<Player>().ingredientNum == 3){
            dialogueBox.SetActive(false); 
        }
    }
}
