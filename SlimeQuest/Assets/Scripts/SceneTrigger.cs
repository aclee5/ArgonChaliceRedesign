using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
   // public int sceneState; 
    public int nextSceneBuildIndex;
    public int sceneState; 
    public bool insideLevel; 
    
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            if(insideLevel){
                SceneManager.LoadScene(nextSceneBuildIndex, LoadSceneMode.Single);
            }
            else{
                FindObjectOfType<SaveSystem>().SavePlayerDataTo(nextSceneBuildIndex); 
                FindObjectOfType<GameManager>().loadScene(sceneState); 

            }
          
            
            

        }

    }
}
