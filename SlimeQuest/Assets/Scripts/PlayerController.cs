using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    [SerializeField]public float moveSpeed; 
    [SerializeField]public Transform movePoint;
    [SerializeField]public Rigidbody2D playerRigidbody2D; 
    private Vector3 moveDir; 
    private Vector2 input; 
    public Animator animator; 
    

    private bool isMoving; 
    private bool faceLeft; 

   
    void Awake(){
        playerRigidbody2D = GetComponent<Rigidbody2D>();   
    }

    // Start is called before the first frame update
    void Start()
    {
        faceLeft = false;       
    }

    // Update is called once per frame
    void Update()
    {
            
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");
            

            moveDir = new Vector3(input.x, input.y).normalized; 

            if(Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0){
                animator.SetBool("isMoving", true); 
            }
            else{
                animator.SetBool("isMoving", false); 
            }

            float inputHorizontal =  Input.GetAxisRaw("Horizontal");
            if(inputHorizontal > 0  && faceLeft){
                Flip();
            }
            if(inputHorizontal < 0 && !faceLeft){
                Flip(); 
            }

                    
        
    }

    void FixedUpdate(){
        playerRigidbody2D.MovePosition(transform.position + moveDir*moveSpeed *Time.deltaTime);        
    }

    void Flip(){
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        faceLeft = !faceLeft; 
    }
      


   
}
