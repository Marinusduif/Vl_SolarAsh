using UnityEngine;

public class AttackAnimation : MonoBehaviour
{
    [SerializeField] private Animator ani;

    [SerializeField] private AttackHit attack;
    void Start()
    {
        ani = GetComponent<Animator>();
        attack = GetComponent<AttackHit>();
    }
    void Update()
    {
        ani.SetTrigger("Idle");
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            ani.SetTrigger("Attack");
            attack.DestroyBox();
        }
    }

}
