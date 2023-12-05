using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHits : MonoBehaviour
{
    [SerializeField] private string targetTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == targetTag)
        {
            Destroy(other.gameObject);
        }
    }
}