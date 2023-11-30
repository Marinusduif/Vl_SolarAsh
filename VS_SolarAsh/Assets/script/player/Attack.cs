using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator ani;
    public string targetTag;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ani.SetTrigger("Idle");
        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            ani.SetTrigger("Attack");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == targetTag) 
        { 
            GameObject.Destroy(other.gameObject);
        }
    }
}
