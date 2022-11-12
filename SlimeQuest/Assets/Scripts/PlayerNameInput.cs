using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class PlayerNameInput : MonoBehaviour
{
    public string name;
    public TMP_InputField inputField; 
    public Player player;  

    public void StoreName(){
        
        name = inputField.text;
        player.characterName = name;  


    }

}
