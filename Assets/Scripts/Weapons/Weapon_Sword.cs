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

    }
}
