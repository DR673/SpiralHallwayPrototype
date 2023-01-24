using UnityEngine;

public class CrashChandelier : MonoBehaviour
{
    public Animator animator;
    public GameObject Script;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.enabled = true;
            Script.GetComponent<SoundNShakeManager>().Active = true;
        }
    }
}
