using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public AudioSource chestSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player")){
            RandomGenerator();
            chestSound.Play();
            Destroy(gameObject);
        }
   }

   void RandomGenerator(){
        
    if(Random.Range(0f, 1f) <= fiveCoinChance )
    {
       Debug.Log ("add 5 coin");
       FindObjectOfType<Player>().coinNum ++;
       FindObjectOfType<Player>().coinNum ++;
       FindObjectOfType<Player>().coinNum ++;
       FindObjectOfType<Player>().coinNum ++;
       FindObjectOfType<Player>().coinNum ++;
    }
    else if(Random.Range(0f, 1f) <= threeCoinChance )
    {
       Debug.Log ("add 3 coin");
       FindObjectOfType<Player>().coinNum ++;
       FindObjectOfType<Player>().coinNum ++;
       FindObjectOfType<Player>().coinNum ++;
    }
    else{
        Debug.Log ("add 2 coin");
        FindObjectOfType<Player>().coinNum ++;
        FindObjectOfType<Player>().coinNum ++;
    }
   }
   const float fiveCoinChance = 2f / 10f;  // Set odds here - e.g. 2 in 10 chance.
    const float threeCoinChance = 5f / 10f;  // Set odds here - e.g. 5 in 10 chance.
}
