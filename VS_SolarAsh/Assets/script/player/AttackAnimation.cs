using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AttackAnimation : MonoBehaviour
{
    [SerializeField] private Animator ani;
    void Start()
    {
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        ani.SetTrigger("Idle");
        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            ani.SetTrigger("Attack");
        }
    }
    
}
