using System;
using UnityEngine;

public class AttackAniEvent : MonoBehaviour
{

    public static event Action<bool> attackEvent;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TriggerAttack(bool toggle)
    {
        attackEvent?.Invoke(toggle);

    }

}
