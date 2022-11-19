using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerController : MonoBehaviour
{
    public DialogueTrigger dialogue;
    public GameObject screenTrigger; 
    public GameObject dialogueManager; 
    public GameObject slideShow; 
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space)){
            slideShow.SetActive(true);
            dialogueManager.SetActive(true); 
            dialogue.StartDialogue(); 
            screenTrigger.SetActive(false); 

        }
        
    }
}
