using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int state;

    //Game States
    private const int INTRODUCTION = -3;
    private const int PLAYER_CUSTOMIZATION = -2;
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

    public void UpdateState(int newState){
        state = newState; 
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

}
