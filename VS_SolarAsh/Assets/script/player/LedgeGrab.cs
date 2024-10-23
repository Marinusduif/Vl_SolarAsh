using System.Collections;
using UnityEngine;

public class LedgeGrab : MonoBehaviour
{
    [SerializeField] private string targetTag;
    [SerializeField] private Animator ani;
    [SerializeField] private CharacterController controller;
    Vector3 climbUp = new Vector3(0, 2.2f, 0);
    Vector3 clibFor = new Vector3(0, 0, 1);

    public bool grabbing = false;

    private void Start()
    {
        ani = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    private void OnTriggerEnter(Collider coll)
    {

        if (coll.gameObject.tag == targetTag && !grabbing)
        {
            StartCoroutine(TimeDelay());
        }
    }
    IEnumerator TimeDelay()
    {
        grabbing = true;

        ani.SetTrigger("Climb");

        yield return new WaitForSeconds(2);

        controller.Move(climbUp);

        yield return new WaitForSeconds(0.5f);

        controller.Move(clibFor);

        grabbing = false;
    }
}
