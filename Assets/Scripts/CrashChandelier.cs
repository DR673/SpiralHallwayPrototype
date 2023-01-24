using UnityEngine;

public class CrashChandelier : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.enabled = true;
        }
    }
}
