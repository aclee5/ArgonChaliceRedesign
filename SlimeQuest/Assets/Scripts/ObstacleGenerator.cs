using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float courseWidth; 
    public float courseHeight;
    private float width, height; 
 

    // Start is called before the first frame update
    void Start()
    {
        width = (float)(courseWidth + 0.2*courseWidth);
        height = (float)(courseHeight + 2);  
  

        float gap = 3; 
        for(int x = 0; x < width; x ++){
            if(x != 0 || x != width){
                if (x%gap == 0){
                float maximumBarrierHeightRatio = 0.8f;
                if(x < 0.2*courseWidth){
                    maximumBarrierHeightRatio = 0.5f; 
                }
                float yScale = Random.Range(0,maximumBarrierHeightRatio); 
                float barrierHeight = yScale*courseHeight; 
                float middleOfBarrier = barrierHeight/2; 

                float randomPlacement = (float) Random.Range(0, 2);
                if(Random.Range(0,2) < 1){
                    middleOfBarrier = courseHeight - middleOfBarrier; 
                }
                

                GameObject barrier = Instantiate(obstaclePrefab, new Vector3(x, middleOfBarrier, 0), Quaternion.identity);
                barrier.transform.localScale = new Vector3(1f, barrierHeight, 1f); 
            }

            if(x == (int)courseWidth/4 || x == (int)courseWidth*0.75){
                gap -= 1; 
           
            }

            }
            
            
        }

        
    }
        

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
