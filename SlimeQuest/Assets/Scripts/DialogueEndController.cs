using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DialogueEndController : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public GameObject actionButton; 

    // Update is called once per frame
    void Update()
    {
        if (dialogueManager.conversationFinished){
            actionButton.SetActive(true); 

        }
    }
}
