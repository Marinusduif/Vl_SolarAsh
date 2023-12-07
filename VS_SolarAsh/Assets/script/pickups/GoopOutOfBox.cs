using UnityEngine;

public class GoopOutOfBox : MonoBehaviour
{
    [SerializeField] private GameObject goob = null;

    public void ExplodeGloobs()
    {
        var go = Instantiate(goob);
        go.transform.position = transform.position;
    }
}
