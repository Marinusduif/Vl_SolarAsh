using UnityEngine;

public class AttackAnimation : MonoBehaviour
{
    [SerializeField] private Animator ani;
    [SerializeField] private AttackHits hit;
    void Start()
    {
        ani = GetComponent<Animator>();
        hit = GetComponent<AttackHits>();
    }

    private void Update()
    {
        ani.SetTrigger("Idle");
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            ani.SetTrigger("Attack");
            hit.DestroyBox();
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            ani.SetTrigger("Walking");
        }
        else
        {
            ani.SetTrigger("Idle");
        }
    }

}
