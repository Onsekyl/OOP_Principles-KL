using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Hammer : Weapon
{
    protected override void OnEnable()
    {
        animator.SetTrigger("SelectHammerTrigger");
    }
    protected override void Attack()
    {
        // https://stackoverflow.com/questions/62417760/how-to-retrieve-the-current-animation-playing-from-animator
        if (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Idle_Hammer")
        {
            animator.SetTrigger("AttackHammerTrigger");
        }
    }
}
