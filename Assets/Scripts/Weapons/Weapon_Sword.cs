using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Sword : Weapon
{
    protected override void OnEnable()
    {
        animator.SetTrigger("SelectSwordTrigger");
    }
    protected override void Attack()
    {
        if (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Idle_Sword")
        {
            animator.SetTrigger("AttackSwordTrigger");
        }
    }
}
