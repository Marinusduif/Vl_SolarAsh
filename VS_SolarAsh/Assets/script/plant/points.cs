using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    public Vector3[] rail;
    void Start()
    {
        
    }

    void Update()
    {
        for(int i = 0; i < rail.Length; i++){
            if(i>0){
            Debug.DrawRay(rail[i-1], rail[i] - rail[i-1], Color.yellow);
            }
        }
    }
}
