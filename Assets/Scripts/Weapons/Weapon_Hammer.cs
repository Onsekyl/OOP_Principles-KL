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
        if (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Idle_Hammer")
        {
            animator.SetTrigger("AttackHammerTrigger");
        }
    }
}
