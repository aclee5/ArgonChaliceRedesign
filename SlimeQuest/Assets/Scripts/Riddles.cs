using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riddles : MonoBehaviour

{
    public DialogueTrigger trigger;
    public GameObject dialogueBox; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            dialogueBox.SetActive(true); 
            trigger.StartDialogue(); 
            
        }
    }

    void OnTriggerExit2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            dialogueBox.SetActive(false); 
        }
    }
}
