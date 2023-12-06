using UnityEngine;

public class AttackHit : MonoBehaviour
{
    [SerializeField] private GameObject box;
    [SerializeField] private bool hit = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == box)
        {
            hit = true;
        }
        else
        {
            hit = false;
        }
    }

    public void DestroyBox()
    {
        if (hit == true)
        {
            Debug.Log("Hello");
            Destroy(box);
        }
    }
}