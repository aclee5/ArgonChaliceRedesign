using System.IO; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    private static readonly string SAVE_FOLDER = Application.dataPath + "/Saves/";
    // Start is called before the first frame update
    void Awake(){
        if(!Directory.Exists(SAVE_FOLDER)){
            Directory.CreateDirectory(SAVE_FOLDER);
        }
    }
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SavePlayerData(){
        GameObject player = GameObject.Find("Player"); 
        PlayerData playerData = new PlayerData(player.GetComponent<Player>()); 
        string json = JsonUtility.ToJson(playerData);
        File.WriteAllText(Application.dataPath + "/save.txt", json);
        Debug.Log("Saved Data");


    }
}
