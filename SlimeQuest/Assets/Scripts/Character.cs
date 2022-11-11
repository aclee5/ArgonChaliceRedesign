using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    public string characterName;

       // Start is called before the first frame update
    void Start()
    {
        if(characterName == null){
            characterName = "Player";
        }
        name = characterName; 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
