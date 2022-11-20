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
    
    private const int CAVEPUZZLE_PT1 = 1;
    private const int CAVEPUZZLE_PT2 = 2;
    private const int BEETLERUN = 3; 
    private const int PUZZLEFORK = 4;
    private const int RUNFORK = 5; 
    private const int RIDDLE = 6; 
    private const int VOID = 7; 
    private const int MAZE = 9; 
    private const int ENDROOM = 10; 
    


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
    public void Play(){
        Time.timeScale = 1;
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void loadScene(int scene){
        switch(scene){
            case START:
                state = START;
                SceneManager.LoadScene("Title"); 
                break;
            case INTRODUCTION:
                state = INTRODUCTION; 
                SceneManager.LoadScene("Introduction");
                break;
            case MAIN_MAP:
                state = MAIN_MAP; 
                SceneManager.LoadScene("Main");
                break;
            case CAVEPUZZLE_PT1:
                state = CAVEPUZZLE_PT1; 
                SceneManager.LoadScene("Cave_Puzzle");
                break;
            case CAVEPUZZLE_PT2:
                SceneManager.LoadScene("Cave2_Puzzle");
                break;
            case BEETLERUN:
                SceneManager.LoadScene("ObstacleCourse");
                break;
            case PUZZLEFORK:
                SceneManager.LoadScene("Maze-Void Choice");
                break;
            case RUNFORK:
                SceneManager.LoadScene("Riddle-Void Choice");
                break;
            case RIDDLE:
                SceneManager.LoadScene("Riddle_Puzzle");
                break;
            case VOID:
                SceneManager.LoadScene("Void");
                break;
            case MAZE:
                SceneManager.LoadScene("Maze");
                break;  

            case ENDROOM:
                SceneManager.LoadScene("End room");
                break; 
            case DRAGON_DUNGEON:
                state = DRAGON_DUNGEON; 
                SceneManager.LoadScene("Dragon"); 
                break;
        }
        
    }

    


}
