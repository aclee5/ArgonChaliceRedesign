using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private Transform player; 
    [SerializeField] private float agroRange;
    [SerializeField] private float moveSpeed;

    private Rigidbody2D rb2d; 
    private Vector2 movement; 

    private Vector2[] moveDirections = new Vector2[] { Vector2.right, Vector2.left, Vector2.up, Vector2.down};
    private int currentMoveDirection;
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
       direction.Normalize(); 
       movement = direction;
       moveCharacter(direction);  


    }

    

    private void moveCharacter(Vector2 direction){
        Vector2 position2D = new Vector2(transform.position.x, transform.position.y); 
        rb2d.MovePosition(position2D + (direction*moveSpeed*Time.deltaTime));

    }

    private void StopPlayerChase(){
        rb2d.velocity = new Vector2(0,0); 

    }

    private void ChooseMoveDirection(){
        currentMoveDirection = Mathf.FloorToInt(Random.Range(0, moveDirections.Length));

    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Player")){
        }
    }
}
