using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPointBehaviour : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            if ((FindObjectOfType<Player>().respawnPoints.Capacity == 0) || (SceneManager.GetActiveScene().buildIndex > FindObjectOfType<Player>().respawnPoints.Capacity-1)){
                FindObjectOfType<Player>().respawnPoints.Add(transform.position); 
            }
            else{
                FindObjectOfType<Player>().respawnPoints[SceneManager.GetActiveScene().buildIndex] = transform.position; 

            }
          
            FindObjectOfType<GameHandler>().SavePlayerData(); 

        }
    }
}
