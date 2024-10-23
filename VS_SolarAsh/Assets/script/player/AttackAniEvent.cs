using System;
using UnityEngine;

public class AttackAniEvent : MonoBehaviour
{
    // Start is called before the first frame update
    public static event Action<int> attackEvent;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AttackHitState(int state)
    {
        attackEvent?.Invoke(state);
    }
}
