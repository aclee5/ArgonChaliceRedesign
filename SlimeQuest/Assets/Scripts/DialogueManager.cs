using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DialogueManager : MonoBehaviour
{
    public Image actorImage; 
    public TMP_Text actorName;
    public TMP_Text messageText;
    public RectTransform backgroundBox;

    Message[] currentMessages;
    Actor[] currentActors;
    int activeMessage = 0; 
    public bool isActive = false;
    private string playerStandin = "<>";
    public bool conversationFinished; 

    public void OpenDialogue(Message[] messages, Actor[] actors){
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0; 
        isActive = true;
        conversationFinished = false; 

        Debug.Log("Started conversation! Loaded messages" + messages.Length); 
        DisplayMessage();


    }

    public void NextMessage(){
        activeMessage++;
        if (activeMessage < currentMessages.Length){
            DisplayMessage();
        }
        else{
            Debug.Log("Conversation Ended!"); 
            isActive = false; 
            conversationFinished = true; 
        }
    } 

    void DisplayMessage(){
        Message messageToDisplay = currentMessages[activeMessage];
        if(messageToDisplay.message.Contains(playerStandin)){
            string[] messageSplit = messageToDisplay.message.Split(playerStandin);
            messageToDisplay.message = string.Join(FindObjectOfType<Player>().characterName, messageSplit);            

        }


       

        messageText.text = messageToDisplay.message;
        Actor actorToDisplay = currentActors[messageToDisplay.actorID];
        Character character = actorToDisplay.character.GetComponent<Character>();
        if (character != null){
            actorName.text = actorToDisplay.character.GetComponent<Character>().characterName; 

        }

        actorImage.sprite = actorToDisplay.sprite; 
       

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isActive == true){
            NextMessage();
        }
        
    }
}
