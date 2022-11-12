using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string characterName; 
    public int ingredientNum;

    public PlayerData(Player player){
        characterName = player.characterName;
        ingredientNum = player.ingredientNum; 
    }


}
