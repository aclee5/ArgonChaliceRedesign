using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextEnable : MonoBehaviour
{

    public TMP_Text collectText;

    public void Start() {
        collectText.enabled = false;

    }

    public void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag("PotionIngredient") || collider.CompareTag("DragonItem")){
            collectText.enabled = true;
            Invoke("DisableText", 1.2f);
        }
    }

    // Start is called before the first frame update
    // void Start()
    // {
    //     Invoke("DisableText", 5f);
    // }

    void DisableText(){
        collectText.enabled = false;
    }
}
