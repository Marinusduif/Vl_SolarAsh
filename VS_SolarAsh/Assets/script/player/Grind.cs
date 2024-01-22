using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Grind : MonoBehaviour
{
    [SerializeField] private Collider col;
    [SerializeField] private int start;
    [SerializeField] private points points;
    [SerializeField] private float speed = 1;
    [SerializeField] private int nextWaypointIndex = 1;
    [SerializeField] private float reachedWaypointClearance = 0.25f;
    [SerializeField] private bool forward;
    private bool canGrind = true;
    public bool grinding;
    [SerializeField] private int closest;

    void Start()
    {

    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(stopGrinding());
        }
        if(forward && grinding)
        {
            moveForward();
        }
        else if(!forward && grinding)
        {
            moveBackwards();
        }
    }

    void moveForward()
    {
         transform.position = Vector3.MoveTowards(transform.position, points.rail[nextWaypointIndex] + Vector3.up * 1.44f, Time.deltaTime * speed);

        if(Vector3.Distance(transform.position, points.rail[nextWaypointIndex] + Vector3.up * 1.44f) <= reachedWaypointClearance && forward && nextWaypointIndex < points.rail.Length)
        {
            nextWaypointIndex++;
        }
        if(nextWaypointIndex > points.rail.Length - 1)
        {
            StartCoroutine(stopGrinding());
        }
    }
    
    void moveBackwards()
    {
        transform.position = Vector3.MoveTowards(transform.position, points.rail[nextWaypointIndex] + Vector3.up * 1.44f, Time.deltaTime * speed);

        if(Vector3.Distance(transform.position, points.rail[nextWaypointIndex] + Vector3.up * 1.44f) <= reachedWaypointClearance && !forward && nextWaypointIndex > -1)
        {
            nextWaypointIndex--;
        }
        if(nextWaypointIndex < 0)
        {
            StartCoroutine(stopGrinding());
        }
    }
    void OnTriggerStay(Collider collider)
    {
        Debug.Log("col");
        if(collider.gameObject.tag == "rail" && Input.GetKey(KeyCode.LeftShift) && !grinding && canGrind)
        {
            for(int i = 0;i < points.rail.Length; i++)
            {
                Debug.Log("check");
                if(Vector3.Distance(points.rail[closest], transform.position) > Vector3.Distance(points.rail[i], transform.position))
                {
                    closest = i;
                }

            }
            if(closest == 0)
            {
                forward = true;
            }
            else if (closest == points.rail.Length - 1)
            {
                forward = false;
            }
            else 
            {
                Vector3 direction = Vector3.Normalize(points.rail[closest-1] - points.rail[closest]);
                float angle = Vector3.Angle(direction, transform.forward);
                if(angle < 90)
                {
                    forward = false;
                }
                else
                {
                    forward = true;
                }
            }

            Debug.Log(closest);
            nextWaypointIndex = closest;
            grinding = true;
        }
    }
    IEnumerator stopGrinding()
    {
        grinding = false;
        canGrind = false;
        yield return new WaitForSeconds(0.5f);
        canGrind = true;
    }
}
