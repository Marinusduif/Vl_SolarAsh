using UnityEngine;

public class GoopOutOfBox : MonoBehaviour
{
    [SerializeField] private GoopCollect goobAdd;

    public void ExplodeGloobs()
    {
        goobAdd.goopAmount += 9;
        goobAdd.GoopCount.text = goobAdd.goopAmount.ToString();
    }
}
