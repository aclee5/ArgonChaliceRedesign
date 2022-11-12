using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTrigger : MonoBehaviour
{
    public int sceneState; 
    public int nextSceneBuildIndex;
    
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            FindObjectOfType<SaveSystem>().SavePlayerDataTo(nextSceneBuildIndex); 
            FindObjectOfType<GameManager>().loadScene(sceneState); 
            

        }

    }
}
