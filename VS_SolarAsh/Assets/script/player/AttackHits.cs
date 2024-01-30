using Unity.Services.Analytics;
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
        Debug.Log(coll.gameObject.tag + canHit);
        if (coll.gameObject.tag == TargetTag && canHit)
        {
            coll.gameObject.GetComponent<GoopOutOfBox>().ExplodeGloobs();
            Destroy(coll.gameObject);
        }
        else if(coll.gameObject.tag == "plant" && canHit)
        {
            coll.gameObject.GetComponent<groei>().check();
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
