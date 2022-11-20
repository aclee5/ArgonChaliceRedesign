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
        Inventory inventory = (Inventory)FindObjectOfType(typeof(Inventory)); 

        PlayerData playerData = new PlayerData(); 
            playerData.characterName = player.characterName;
            playerData.coinNum = player.coinNum; 
            // playerData.respawnPoints = player.respawnPoints; 
            playerData.itemIDs = inventory.itemIDs; 

        string json = JsonUtility.ToJson(playerData);
        SaveSystem.Save(json); 

        Debug.Log("Saved Data");


    }

    public void LoadPlayerData(){
        string saveString = SaveSystem.Load();
        if(saveString != null){
            PlayerData playerData = JsonUtility.FromJson<PlayerData>(saveString); 
            Player player = (Player)FindObjectOfType(typeof(Player));
            Inventory inventory = (Inventory)FindObjectOfType(typeof(Inventory)); 
            
            player.SetName(playerData.characterName);
            player.SetCoinNum(playerData.coinNum); 
            // player.respawnPoints = playerData.respawnPoints; 
            inventory.itemIDs = playerData.itemIDs; 

            
            
            Debug.Log("Loaded: " + saveString);

        }
        else{
            Debug.Log("No Save"); 
        }
    }

    public void ResetPlayerData(){
       SaveSystem.Delete(); 
       //UnityEditor.AssetDatabase.Refresh(); 
    }
}
