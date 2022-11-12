using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int state;

    //Game States
    private const int START = -3;
    private const int INTRODUCTION = -2;
    private const int DRAGON_DUNGEON = -1;

    private const int MAIN_MAP = 0; 
    
    private const int INGREDIENT_1 = 1;
    private const int INGREDIENT_2 = 2;
    private const int INGREDIENT_3 = 3; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause(){
        Time.timeScale = 0; 

    }

    public void UpdateState(int newState){
        state = newState; 
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void loadScene(int scene){
        switch(scene){
            case INTRODUCTION:
                SceneManager.LoadScene("Introduction");
                
                break;
            case MAIN_MAP:
                SceneManager.LoadScene("Main");
                break;
            case INGREDIENT_1:
                break;
            case INGREDIENT_2:
                break;
            case INGREDIENT_3:
                break;
            case DRAGON_DUNGEON:
                SceneManager.LoadScene("Dragon"); 
                break;
        }
        
    }

    


}
