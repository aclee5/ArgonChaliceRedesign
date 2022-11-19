using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private Transform player; 
    [SerializeField] private float agroRange;
    [SerializeField] private float moveSpeed;

    Rigidbody2D rb2d; 
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position); 
        if(distToPlayer < agroRange){
            ChasePlayer(); 
        }
        else{
            StopPlayerChase(); 
        }
        
    }

    private void ChasePlayer(){
       Vector3 direction = player.position - transform.position; 
       float angle = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;
       rb2d.rotation = angle; 


    }

    private void StopPlayerChase(){

    }
}
