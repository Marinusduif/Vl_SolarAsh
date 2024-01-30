using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class groei : MonoBehaviour
{
    [SerializeField] private bool gegroeid;
    [SerializeField] private GameObject vein;
    void Start()
    {
        
    }

    void Update()
    {
        
    }


    void groeiPlant()
    {
        vein.SetActive(true);
    }

    void krimpPlant()
    {
        vein.SetActive(false);
    }
    public void check()
    {
        Debug.Log("gechecked");
        if (!gegroeid)
        {
            groeiPlant();
            gegroeid = !gegroeid;
        }
        else
        {
            krimpPlant();
            gegroeid = !gegroeid;
        }
    }
}
