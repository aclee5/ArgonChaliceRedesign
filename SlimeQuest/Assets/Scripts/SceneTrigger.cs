using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    public int nextSceneBuildIndex;
    public string id; 
    
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            FindObjectOfType<GameHandler>().SavePlayerData(); 
            SceneManager.LoadScene(nextSceneBuildIndex, LoadSceneMode.Single);       
            
            

        }

    }
}
