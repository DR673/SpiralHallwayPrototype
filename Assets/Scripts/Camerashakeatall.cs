using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerashakeatall : MonoBehaviour
{
    public CameraShake cameraShake;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(cameraShake.Shake(1f, .03f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InititateShake()
    {
        StartCoroutine(cameraShake.Shake(1f, .03f));
    }
}
