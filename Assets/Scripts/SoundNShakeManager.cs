using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundNShakeManager : MonoBehaviour
{
    public float TimeRemaining = 2f;

   // public GameObject audiosource, audiosource2, audiosource3, particleobject;
    public GameObject audiosource, audiosource2, audiosource3, particleobject;


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

            if (Done && TimeRemaining <= 1.4f)
            {
                audiosource2.SetActive(true);
            }

            if (Done && TimeRemaining <= 1.36f)
            {
                audiosource3.SetActive(true);
            }


            if (Done && TimeRemaining <= 1.32f)
            {
                audiosource.SetActive(true);
                
            }

            if (Done && TimeRemaining <= 1.2f)
            {
                
                particleobject.SetActive(true);
            }


            if (Done && TimeRemaining <= 1)
            {
                
                gameObject.GetComponent<Camerashakeatall>().InititateShake();
                

                Done = false;

            }

        }
    }
}
