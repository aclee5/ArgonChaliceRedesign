using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour

{
    //potion ingredients objects
    public GameObject IngredientOne;
    public GameObject IngredientTwo;
    public GameObject IngredientThree;

    //dragon item objects 
    public GameObject dragonItemOne;
    public GameObject dragonItemTwo;
    public GameObject dragonItemThree;
    public GameObject dragonItemFour;
    public GameObject dragonItemFive;



    // Start is called before the first frame update
    void Start()
    {   
        
        Instantiate(IngredientOne, new Vector3(5, 5, 0), Quaternion.identity);
        Instantiate(IngredientTwo, new Vector3(10, 10,0), Quaternion.identity);
        Instantiate(IngredientThree, new Vector3(-7,-8, 0), Quaternion.identity);

        //instantiate dragon items 
        Instantiate(dragonItemOne, new Vector3(-14,-8, 0), Quaternion.identity);
        Instantiate(dragonItemTwo, new Vector3(14,-8, 0), Quaternion.identity);
        Instantiate(dragonItemThree, new Vector3(2,-14, 0), Quaternion.identity);
        Instantiate(dragonItemFour, new Vector3(3,-10, 0), Quaternion.identity);
        Instantiate(dragonItemFive, new Vector3(-10,10, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
