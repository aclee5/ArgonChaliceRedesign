using System.IO; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        GameObject player = GameObject.Find("Player"); 
        PlayerData playerData = new PlayerData(player.GetComponent<Player>()); 
        string json = JsonUtility.ToJson(playerData);
        SaveSystem.Save(json); 

        Debug.Log("Saved Data");


    }

    public void LoadPlayerData(){
        string saveString = SaveSystem.Load();
        if(saveString != null){
            PlayerData playerData = JsonUtility.FromJson<PlayerData>(saveString); 
            Player player = (Player)FindObjectOfType(typeof(Player));
            player.characterName = playerData.characterName; 
            player.ingredientNum = playerData.ingredientNum; 
            player.dragonItemNum = playerData.dragonItemNum; 

            Debug.Log("Loaded: " + saveString);

        }
        else{
            Debug.Log("No Save"); 
        }
    }
}
