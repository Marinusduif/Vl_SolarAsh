using UnityEngine;

public class AttackHits : MonoBehaviour
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
            Destroy(box);
        }
    }
}
