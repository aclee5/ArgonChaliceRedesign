using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLoader : MonoBehaviour
{
   void Awake(){
        FindObjectOfType<SaveSystem>().LoadPlayerData(); 
   }
}
