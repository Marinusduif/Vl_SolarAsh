using UnityEngine;

public class AttackAnimation : MonoBehaviour
{
    [SerializeField] private Animator ani;
<<<<<<< HEAD
    void Start()
    {
        ani = GetComponent<Animator>();
=======
    [SerializeField] private AttackHits hit;
    void Start()
    {
        ani = GetComponent<Animator>();
        hit = GetComponent<AttackHits>();
>>>>>>> 0eecaefa56e79caa0d6bdd2b696b45e214c796a0
    }

    private void Update()
    {
        ani.SetTrigger("Idle");
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ani.SetTrigger("Attack");
<<<<<<< HEAD
=======
            hit.DestroyBox();
>>>>>>> 0eecaefa56e79caa0d6bdd2b696b45e214c796a0
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
