using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField]
    protected Animator animator;

    [SerializeField]
    protected int _weaponDamage;

    public int damage
    {
        get
        {
            return _weaponDamage;
        }
        protected set
        {
            if (value < 1)
            {
                Debug.Log("Damage can not be 0 or below!");
            }
            else
            {
                _weaponDamage = value;
            }
        }
    }

    protected void Start()
    {
        damage = _weaponDamage;
    }

    protected void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Attack();
        }
    }

    protected abstract void OnEnable();
    protected abstract void Attack();

}
