using UnityEngine;

public class LedgeGrab : MonoBehaviour
{
    [SerializeField] private string targetTag;
    [SerializeField] private Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            ani.SetTrigger("Climb");
        }
    }
}
