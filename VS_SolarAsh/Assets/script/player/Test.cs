using System;
using UnityEngine;

public class Test : MonoBehaviour
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

    public void Testing(int state)
    {

        attackEvent?.Invoke(state);
    }
}
