using UnityEngine;

public class AttackAnimation : MonoBehaviour
{
    [SerializeField] private Animator ani;
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        ani.SetTrigger("Idle");
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ani.SetTrigger("Attack");
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
