using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeLogic : MonoBehaviour
{

    public SpriteRenderer sr, sr2, sr3;
    public Color green = Color.green;
    public bool b1Active, b2Active, b3Active;

    public GameObject IngredientOne; 

    // Start is called before the first frame update
    void Start()
    {
        sr = GameObject.Find("ButtonOne").GetComponent<SpriteRenderer>();
        sr2 = GameObject.Find("ButtonTwo").GetComponent<SpriteRenderer>();
        sr3 = GameObject.Find("ButtonThree").GetComponent<SpriteRenderer>();
        b1Active =false;
        b2Active = false;
        b3Active = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(b1Active && b2Active && b3Active){
            ///win condition all buttons pressed can spawn item and then leave
            Instantiate(IngredientOne, new Vector3(50, -5, 0), Quaternion.identity);
        }
    }

    public void OnTriggerEnter2D(Collider2D collider){
        //chcekcs which button the player collides with
        if(collider.CompareTag("MazeB1")){
            sr.color = green;
            b1Active = true;

        }
        if(collider.CompareTag("MazeB2")){
            sr2.color = green;
            b2Active = true;
        }
        if(collider.CompareTag("MazeB3")){
            sr3.color = green;
            b3Active = true;
        }
    }
}
