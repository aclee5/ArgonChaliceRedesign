using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Sign : MonoBehaviour
{

    public DialogueTrigger trigger;
    public GameObject dialogueBox; 
    // Start is called before the first frame update
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

    // public GameObject dialogBox;
    // public TMP_Text dialogText;
    // public string dialog;
    // public bool playerInRange;

    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     if(Input.GetKey(KeyCode.Space) && playerInRange)
    //     {
    //         if(dialogBox.activeInHierarchy)
    //         {
    //             dialogBox.SetActive(false);
    //         }
    //         else {
    //             dialogBox.SetActive(true);
    //             dialogText.text = dialog;
    //         }
    //     }
    // }

    // public void OnTriggerEnter2D(Collider2D other)
    // {
    //     if(other.CompareTag("Player"))
    //     {
    //         playerInRange = true;
    //         Debug.Log("Player in range");
    //     }
    // }
    
    // public void OnTriggerExit2D(Collider2D other){
    //     if(other.CompareTag("Player")){
    //         playerInRange = false;
    //         Debug.Log("PLayer left  range");
    //     }
    // }

}
