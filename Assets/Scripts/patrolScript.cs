using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolScript : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 5;
    int currentWayPoint;
    Vector3 target,
        moveDirection;

    private bool flag = true;

    // Update is called once per frame
    void Update()
    {
        target = waypoints[currentWayPoint].position;
        moveDirection = target - transform.position;
        if (moveDirection.magnitude < 1 && flag)
        {
            currentWayPoint = (currentWayPoint + 1) % waypoints.Length;
            StartCoroutine(Stay());
        }

        GetComponent<Rigidbody>().velocity = moveDirection.normalized * speed;
    }

    IEnumerator Stay()
    {
        flag = false;
        yield return new WaitForSeconds(5);
        flag = true;
    }
}
