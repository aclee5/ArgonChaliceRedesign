using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

   void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player")){
            FindObjectOfType<Player>().coinNum ++; 
            Destroy(gameObject);
        }
   }
}
