using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundNShakeManager : MonoBehaviour
{
    public float TimeRemaining = 1f;

    public GameObject audiosource;

    public bool Done;
    public bool Active;

    // Start is called before the first frame update
    void Start()
    {     
        Active = false;
        Done = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Active)
        {
            TimeRemaining -= Time.deltaTime;

            if (Done && TimeRemaining <= 0)
            {
                //audiosource.SetActive(true);
                gameObject.GetComponent<Camerashakeatall>().InititateShake();

                Done = false;

            }
        }
    }
}
