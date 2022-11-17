using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPointBehaviour : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            FindObjectOfType<Player>().respawnPoints[SceneManager.GetActiveScene().buildIndex] = transform.position; 
            FindObjectOfType<GameHandler>().SavePlayerData(); 

        }
    }
}
