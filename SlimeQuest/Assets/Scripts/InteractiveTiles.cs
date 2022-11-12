using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveTiles : MonoBehaviour
{
    public SpriteRenderer sr;
    public Color colorA = Color.red;
    public Color colorB = Color.black;

    // Start is called before the first frame update
    void Start()
    {
        sr = GameObject.Find("Square").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collider){
        Debug.Log("testing ");
        sr.color = colorB;
        //here can test if the correct square is triggered and change its colour 
        
    }
    public void OnTriggerExit2D(Collider2D collider){
        Debug.Log("exited");
        //sr.color = colorA;
    }
}
