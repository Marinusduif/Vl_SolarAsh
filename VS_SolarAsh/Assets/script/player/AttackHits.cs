using UnityEngine;

public class AttackHits : MonoBehaviour
{
    [SerializeField] private string TargetTag;
    private bool canHit = false;

    private void Start()
    {
        AttackAniEvent.attackEvent += CheckHitState;
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == TargetTag && canHit)
        {
            Destroy(coll.gameObject);
            coll.gameObject.GetComponent<GoopOutOfBox>().ExplodeGloobs();
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
