using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{

    
    int[,] ar = new int[5,5];
    
    void Start()
    {
        for(int i = 0; i < 5; i++){
            for(int j = 0; j < 5; j++){
                ar[i,j] = Random.Range(0,10);
                Debug.Log(ar[i,j]);
            }

        }

    }

    void Update()
    {
        
    }
}
