using System.IO; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{ 
   
    // Start is called before the first frame update
    void Awake(){
        SaveSystem.Init();
        
    }
    void Start()
    {
        LoadPlayerData(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SavePlayerData(){
        Player player = (Player)FindObjectOfType(typeof(Player));
        PlayerData playerData = new PlayerData(); 
            playerData.characterName = player.characterName;
            playerData.ingredientNum = player.ingredientNum; 
            playerData.dragonItemNum = player.dragonItemNum;
            playerData.respawnPoints = player.respawnPoints; 

        string json = JsonUtility.ToJson(playerData);
        SaveSystem.Save(json); 

        Debug.Log("Saved Data");


    }

    public void LoadPlayerData(){
        string saveString = SaveSystem.Load();
        if(saveString != null){
            PlayerData playerData = JsonUtility.FromJson<PlayerData>(saveString); 
            Player player = (Player)FindObjectOfType(typeof(Player));
            
            player.SetName(playerData.characterName);
            player.SetIngredientNumber(playerData.ingredientNum); 
            player.SetDragonNumber(playerData.dragonItemNum);
            player.respawnPoints = playerData.respawnPoints; 
            
            Debug.Log("Loaded: " + saveString);

        }
        else{
            Debug.Log("No Save"); 
        }
    }
}
