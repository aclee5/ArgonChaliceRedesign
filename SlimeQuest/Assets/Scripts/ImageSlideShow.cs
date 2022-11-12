using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ImageSlideShow : MonoBehaviour
{
    public Image image; 
    public Sprite[] slideShowImages; 
    private int activeImage; 
    private bool isActive; 

    // Start is called before the first frame update
    void Start()
    {
        activeImage = 0; 
        isActive = true; 
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Space) && isActive == true){
            NextImage();
        }
        
    }

    void NextImage(){
        activeImage ++; 
         if (activeImage < slideShowImages.Length){
            image.sprite = slideShowImages[activeImage]; 

        }
        else{
            Debug.Log("Slideshow Finished"); 
            isActive = false; 
        }
    }

}
