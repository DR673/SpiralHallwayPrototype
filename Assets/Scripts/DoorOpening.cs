using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    public GameObject Room1Door;

    public GameObject PlayerCharacter;

    public float DistanceToPlayer;

    public bool WithinRange = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Room1Door.transform.position, PlayerCharacter.transform.position);

        if (distance <= DistanceToPlayer)
        {
            WithinRange = true;
        }

        else
        {
            WithinRange = false;
        }

        if (Input.GetKeyUp(KeyCode.E) && WithinRange == true)
        {
            DoorOpen();
        }
    }

    public void DoorOpen()
    {
        Room1Door.GetComponent<DoorMovingDown>().CanMoveEnabler();
    }
}
