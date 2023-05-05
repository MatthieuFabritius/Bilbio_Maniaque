using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimations : MonoBehaviour
{
    public Animator animator;

    public void LaunchCreditAnimation()
    {
        animator.SetTrigger("IsPlayed");
    }

    public void LaunchOptionsAnimation()
    {
        animator.SetTrigger("OptionTrigger");
    }


}
