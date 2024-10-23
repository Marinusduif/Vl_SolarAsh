using UnityEngine;

public class GoopOutOfBox : GoopCollect
{
    [SerializeField] private GameObject goob = null;


    private void Start()
    {

    }

    public void ExplodeGloobs()
    {
        goopAmount += 9;
        GoopCount.text = goopAmount.ToString();
    }
}
