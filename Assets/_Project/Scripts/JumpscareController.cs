using System.Collections;
using UnityEngine;

public class JumpscareController : MonoBehaviour
{
    private Animator animator;
    private JumpscareSoundPlay jumpscareSoundPlay;
    private int coin;

    void Start()
    {
        animator = GetComponent<Animator>();
        jumpscareSoundPlay = GetComponent<JumpscareSoundPlay>();
        StartCoroutine(JumpscareRoutine());
    }

    IEnumerator JumpscareRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            coin = Random.Range(0, 10000);
            if (coin == 0)
            {
                animator.SetTrigger("Jumpscare");
                // jumpscareSoundPlay.PlayAudio();
            }
        }
        
    }
}
