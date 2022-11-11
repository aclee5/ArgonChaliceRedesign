using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonBehaviour : Character
{
    public int giftNum; 
    private int giftTotal; 
    public DialogueTrigger introTrigger; 

    // Start is called before the first frame update
    void Start()
    {
        giftNum = 0; 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Player") == true){
            introTrigger.StartDialogue();

        }
        
    }
}
