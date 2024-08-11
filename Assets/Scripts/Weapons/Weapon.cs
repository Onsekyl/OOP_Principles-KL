using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected int damage;

    [SerializeField]
    private int _weaponDamage;

    protected void Start()
    {
        damage = _weaponDamage;
    }

    protected void Update()
    {

    }

    protected abstract void Select();
    protected abstract void Attack();

}
