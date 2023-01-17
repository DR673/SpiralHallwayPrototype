using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    public GameObject Room1EntranceDoor;
    public GameObject Room1ExitDoor;
    public GameObject Room2EntranceDoor;
    public GameObject Room2ExitDoor;

    public GameObject PlayerCharacter;

    public float DistanceToPlayer;

    public bool WithinRange1 = false;
    public bool WithinRange2 = false;
    public bool WithinRange3 = false;
    public bool WithinRange4 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance1 = Vector3.Distance(Room1EntranceDoor.transform.position, PlayerCharacter.transform.position);
        float distance2 = Vector3.Distance(Room1ExitDoor.transform.position, PlayerCharacter.transform.position);
        float distance3 = Vector3.Distance(Room2EntranceDoor.transform.position, PlayerCharacter.transform.position);
        float distance4 = Vector3.Distance(Room2ExitDoor.transform.position, PlayerCharacter.transform.position);

        if (distance1 <= DistanceToPlayer)
        {
            WithinRange1 = true;
        }
        else
        {
            WithinRange1 = false;
        }
        if (Input.GetKeyUp(KeyCode.E) && WithinRange1 == true)
        {
            Room1EntranceDoorOpen();
        }

        if (distance2 <= DistanceToPlayer)
        {
            WithinRange2 = true;
        }
        else
        {
            WithinRange2 = false;
        }
        if (Input.GetKeyUp(KeyCode.E) && WithinRange2 == true)
        {
            Room1ExitDoorOpen();
        }

        if (distance3 <= DistanceToPlayer)
        {
            WithinRange3 = true;
        }
        else
        {
            WithinRange3 = false;
        }
        if (Input.GetKeyUp(KeyCode.E) && WithinRange3 == true)
        {
            Room2EntranceDoorOpen();
        }

        if (distance4 <= DistanceToPlayer)
        {
            WithinRange4 = true;
        }
        else
        {
            WithinRange4 = false;
        }
        if (Input.GetKeyUp(KeyCode.E) && WithinRange4 == true)
        {
            Room2ExitDoorOpen();
        }
    }

    public void Room1EntranceDoorOpen()
    {
        Room1EntranceDoor.GetComponent<DoorMovingDown>().CanMoveEnabler();
    }

    public void Room1ExitDoorOpen()
    {
        Room1ExitDoor.GetComponent<DoorMovingDown>().CanMoveEnabler();
    }

    public void Room2EntranceDoorOpen()
    {
        Room2EntranceDoor.GetComponent<DoorMovingDown>().CanMoveEnabler();
    }

    public void Room2ExitDoorOpen()
    {
        Room2ExitDoor.GetComponent<DoorMovingDown>().CanMoveEnabler();
    }
}
