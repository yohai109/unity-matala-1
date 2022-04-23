using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolScript : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed;
    int currentWayPoint;
    Vector3 target,
        moveDirection;
    public Transform finishPoint;
    private bool isFinishedFlag = false;
    private bool flag = true;

    void Start()
    {
        speed = GameObject.FindWithTag("Manager").GetComponent<ManagerScript>().patrolSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFinishedFlag)
        {
            target = waypoints[currentWayPoint].position;
        }
        else
        {
            target = finishPoint.position;
        }
        moveDirection = target - transform.position;
        if (moveDirection.magnitude < 1 && flag)
        {
            currentWayPoint = (currentWayPoint + 1) % waypoints.Length;
            StartCoroutine(Stay());
            if(isFinishedFlag) {
                 GameObject.FindWithTag("Manager").GetComponent<ManagerScript>().PatrolAtFinishPoint();
            }
        }

        GetComponent<Rigidbody>().velocity = moveDirection.normalized * speed;
    }

    IEnumerator Stay()
    {
        flag = false;
        yield return new WaitForSeconds(5);
        flag = true;
    }

    public void setSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public void GoToFinish()
    {
        isFinishedFlag = true;
    }
}
