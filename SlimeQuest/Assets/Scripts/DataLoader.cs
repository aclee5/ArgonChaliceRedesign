using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLoader : MonoBehaviour
{
   void Start(){
        FindObjectOfType<SaveSystem>().LoadPlayerData(); 
   }
}
