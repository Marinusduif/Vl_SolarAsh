using UnityEngine;

public class AttackAnimation : MonoBehaviour
{
    [SerializeField] private Animator ani;

    [SerializeField] private AttackHits attack;
    void Start()
    {
        ani = GetComponent<Animator>();
        attack = GetComponent<AttackHits>();
    }

    private void Update()
    {
        ani.SetTrigger("Idle");
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            ani.SetTrigger("Attack");
            attack.DestroyBox();
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
