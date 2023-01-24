using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportOnE : MonoBehaviour
{
    public GameObject PlayerCharacter;
    public GameObject Door;
    public Transform StartPosition;
    public float range = 2f;
    public Vector3 teleportLocation = new Vector3(13.5f, -0.8f, -17.6f);
    public float fadeSpeed = 0.5f;

    private bool withinRange = false;

    public GameObject Camera;

    void Update()
    {
        // Check if object1 is within range of object2
        float distance = Vector3.Distance(PlayerCharacter.transform.position, Door.transform.position);
        if (distance <= range)
        {
            withinRange = true;
        }

        else
        {
            withinRange = false;
        }

        // Check if "E" key is pressed
        if (withinRange && Input.GetKeyDown(KeyCode.E))
        {
            Camera.GetComponent<CameraFadeOnStart>().Fade();

            PlayerCharacter.transform.position = StartPosition.position;
        }
    }
}
