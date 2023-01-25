using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnStopperFinal : MonoBehaviour
{
    public GameObject Pawn;

    public GameObject Queen;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pawn")
        {
            Destroy(Pawn);

            Queen.SetActive(true);
        }
    }
}
