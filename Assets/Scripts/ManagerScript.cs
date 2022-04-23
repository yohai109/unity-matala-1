using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    public int clickedButtons = 0;
    public float patrolSpeed = 5;

    const int MAX_CLICKS = 3;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        // if (clickedButtons == 1)
        // {
        //     patrolSpeed = 10;
        // }
        // else if (clickedButtons == 2)
        // {
        //     patrolSpeed = 15;
        // }
        // else if (clickedButtons == 3)
        // {
        //     // TODO add "You win" screen
        // }
    }

    public void clickButton()
    {
        if (clickedButtons < MAX_CLICKS)
        {
            clickedButtons++;

            if (clickedButtons == 1)
            {
                patrolSpeed = 10;
            }
            else if (clickedButtons == 2)
            {
                patrolSpeed = 15;
            }
            else if (clickedButtons == 3)
            {
                // TODO add "You win" screen
            }
            GameObject.FindWithTag("Patrol").GetComponent<patrolScript>().setSpeed(patrolSpeed);
        }
    }
}
