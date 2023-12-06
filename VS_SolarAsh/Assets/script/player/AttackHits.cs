using UnityEngine;

public class AttackHits : MonoBehaviour
{
    [SerializeField] private string TargetTag;
    private bool canHit = false;


    private void Start()
    {
        Test.attackEvent += CheckHitState;
    }
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == TargetTag && canHit)
        {
            Destroy(coll.gameObject);
        }
    }

    private void CheckHitState(int state)
    {
        if (state == 1)
        {
            canHit = true;
        }
        else
        {
            canHit = false;
        }

    }
}
