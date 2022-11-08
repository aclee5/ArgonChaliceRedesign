using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string name; 

    public PlayerData(Player player){
        name = player.name;
    }


}
