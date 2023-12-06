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

<<<<<<< HEAD
=======
    public void DestroyBox()
    {
        if (hit == true)
        {
            Destroy(box);
        }
>>>>>>> 0eecaefa56e79caa0d6bdd2b696b45e214c796a0
    }
}
