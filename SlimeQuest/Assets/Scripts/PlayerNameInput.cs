using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class PlayerNameInput : MonoBehaviour
{
    public string charName;
    public TMP_InputField inputField; 
    public Player player;  

    public void StoreName(){
        
        charName = inputField.text;
        player.characterName = charName;
        Debug.Log("Player is" + charName);

    }

}
