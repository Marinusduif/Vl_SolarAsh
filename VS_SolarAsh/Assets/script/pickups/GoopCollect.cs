using TMPro;
using UnityEngine;

public class GoopCollect : MonoBehaviour
{
    private int goopAmount;

    public TextMeshProUGUI GoopCount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == ("Goop"))
        {
            goopAmount++;
            GoopCount.text = goopAmount.ToString();
            Destroy(other.gameObject);


        }
    }

}
