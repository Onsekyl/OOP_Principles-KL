using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Dagger : Weapon
{
    protected override void OnEnable()
    {
        animator.SetTrigger("SelectDaggerTrigger");
    }
    protected override void Attack()
    {
        animator.SetTrigger("AttackDaggerTrigger");
    }
}
