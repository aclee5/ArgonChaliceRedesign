using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float courseWidth; 
    public float courseHeight;  

    // Start is called before the first frame update
    void Start()
    {
        for(int x = 0; x < courseWidth; x ++){
            
            if (Random.Range(0, 5) < 1){
                float yScale = Random.Range(0, 0.75f); 
                float middleOfBarrier = courseHeight*yScale/2; 

                GameObject barrier = Instantiate(obstaclePrefab, new Vector3(x, middleOfBarrier, 0), Quaternion.identity);
                // barrier.transform.localScale.y = yScale; 
            }
                
           
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
