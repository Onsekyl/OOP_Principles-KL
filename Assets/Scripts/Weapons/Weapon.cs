using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public abstract class Weapon : MonoBehaviour
{
    [SerializeField]
    protected Animator animator;
    [SerializeField]
    protected int _weaponDamage;
    [SerializeField]
    protected DamageDisplayer _damageDisplayer;

    // ENCAPSULATION
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
        // Necessary way to do initialization for the setter check
        damage = _weaponDamage;
    }

    protected void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            // ABSTRACTION
            Attack();
        }
    }

    protected void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            _damageDisplayer.DisplayDamage(damage, other.gameObject);
        }
    }

    protected abstract void OnEnable();
    protected abstract void Attack();

}
