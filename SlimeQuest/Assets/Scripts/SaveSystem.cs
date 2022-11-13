using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; 
using System.Runtime.Serialization.Formatters.Binary; 
using UnityEngine.SceneManagement; 

public class SaveSystem : MonoBehaviour
{
    const string PLAYER_SUB = "/player";
    
    public void SavePlayerData(Player player){
        string pathAddition = PLAYER_SUB + SceneManager.GetActiveScene().buildIndex; 
        
        BinaryFormatter formatter = new BinaryFormatter();
        string path = System.IO.Path.Combine(Application.persistentDataPath, pathAddition); 

        FileStream stream = new FileStream(path, FileMode.Create); 
        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close(); 

    }

    public void SavePlayerDataTo(int index){
        BinaryFormatter formatter = new BinaryFormatter();
        string pathAddition = PLAYER_SUB + index;
        string path = System.IO.Path.Combine(Application.persistentDataPath, pathAddition); 

        FileStream stream = new FileStream(path, FileMode.Create); 
        PlayerData data = new PlayerData((Player)FindObjectOfType(typeof(Player)));

        formatter.Serialize(stream, data);
        stream.Close(); 

    }


    public void LoadPlayerData(){
        BinaryFormatter formatter = new BinaryFormatter();
        string pathAddition = PLAYER_SUB + SceneManager.GetActiveScene().buildIndex; 
        string path = System.IO.Path.Combine(Application.persistentDataPath, pathAddition); 

        if (File.Exists(path)){
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();  

            Player player = (Player)FindObjectOfType(typeof(Player));
            player.characterName = data.characterName; 
            player.ingredientNum = data.ingredientNum; 
            player.dragonItemNum = data.dragonItemNum; 
            Debug.Log("Loaded Data From " + SceneManager.GetActiveScene().buildIndex + "|| dragonItemsAre: " + player.dragonItemNum + "|| IngredientNum: " + player.ingredientNum); 


        }
        else{
            Debug.LogError("Path not found in " + path);
        }


    }

}
