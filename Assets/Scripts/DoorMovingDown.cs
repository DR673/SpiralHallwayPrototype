using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovingDown : MonoBehaviour
{
    public float speed = 1f;
    public float distanceMoved = 0;
    public float distanceToMove = 5f;
    private bool moveComplete = false;
    public bool canMove = false;

    public void CanMoveEnabler()
    {
        canMove = true;
    }

    void Update()
    {
        if (!moveComplete && canMove)
        {
            distanceMoved += speed * Time.deltaTime;
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
            if (distanceMoved >= distanceToMove)
            {
                moveComplete = true;
            }
        }
    }
}
