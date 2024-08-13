using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Weapon_Sword : Weapon
{
    // POLYMORPHISM
    protected override void OnEnable()
    {
        animator.SetTrigger("SelectSwordTrigger");
    }
    // POLYMORPHISM
    protected override void Attack()
    {
        // https://stackoverflow.com/questions/62417760/how-to-retrieve-the-current-animation-playing-from-animator
        if (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Idle_Sword")
        {
            animator.SetTrigger("AttackSwordTrigger");
        }
    }
}
