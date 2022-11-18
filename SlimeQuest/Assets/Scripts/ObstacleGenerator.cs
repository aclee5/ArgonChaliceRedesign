using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject courseBounds; 
    private float courseWidth; 
    private float courseHeight;
 

    // Start is called before the first frame update
    void Start()
    {
        courseWidth = courseBounds.transform.localScale.x;
        courseHeight = courseBounds.transform.localScale.y; 
       
  

        float gap = 4; 
        for(int x = 0; x < courseWidth; x ++){
    
            if (x%gap == 0){
            float maximumBarrierHeightRatio = 0.6f;
            if(x < 0.1*courseWidth){
                maximumBarrierHeightRatio = 0.4f; 
            }
            float yScale = Random.Range(0,maximumBarrierHeightRatio); 
            float barrierHeight = yScale*courseHeight; 
            float middleOfBarrier = barrierHeight/2; 

            float randomPlacement = (float) Random.Range(0, 2);
            if(Random.Range(0,2) < 1 && x > (0.1*courseWidth)){
                middleOfBarrier = courseHeight - middleOfBarrier; 
            }
            

            GameObject barrier = Instantiate(obstaclePrefab, new Vector3(x + 0.5f, middleOfBarrier, 0), Quaternion.identity);
            barrier.transform.localScale = new Vector3(1f, barrierHeight, 1f); 
        }

        if(x == (int)courseWidth/4 || x == (int)courseWidth*0.75){
            gap -= 1; 
        
        }

            
            
            
        }

        
    }
        

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
