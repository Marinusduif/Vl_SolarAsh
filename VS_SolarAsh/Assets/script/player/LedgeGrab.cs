using System.Collections;
using UnityEngine;

public class LedgeGrab : MonoBehaviour
{
    [SerializeField] private string targetTag;
    [SerializeField] private Animator ani;
    [SerializeField] private CharacterController controller;
    Vector3 climb = new Vector3(0, 2, 1);

    bool flag = false;

    private void Start()
    {
        ani = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();

    }

    private void OnTriggerEnter(Collider coll)
    {

        if (coll.gameObject.tag == targetTag && !flag)
        {
            StartCoroutine(TimeDelay());
        }
    }
    IEnumerator TimeDelay()
    {
        flag = true;
        ani.SetTrigger("Climb");


        yield return new WaitForSeconds(2);

        controller.Move(climb);
        flag = false;
    }
}
