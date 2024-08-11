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
        animator.SetTrigger("AttackHammerTrigger");
    }
}
