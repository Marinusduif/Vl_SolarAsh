﻿using UnityEngine;

public class GoopOutOfBox : MonoBehaviour
{
    [SerializeField] private GameObject goob = null;
    [SerializeField] private GoopCollect goobAdd;

    private void Start()
    {

    }

    public void ExplodeGloobs()
    {
        goobAdd.goopAmount += 9;
        goobAdd.GoopCount.text = goobAdd.goopAmount.ToString();
    }
}
