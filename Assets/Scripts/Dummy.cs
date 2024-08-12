using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    [SerializeField]
    private Animator _dummyAnim;
    [SerializeField]
    private int _dummyHealth = 100;

    private void Start()
    {

    }

    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapon"))
        {
            ReceiveDamage(other.GetComponent<Weapon>().damage);
        }
    }

    public void ReceiveDamage(int damage)
    {
        _dummyHealth -= damage;

        Debug.Log(damage + " damage received!");

        if (_dummyHealth <= 0)
        {
            Die();
        }

        if (_dummyAnim != null)
        {
            // https://docs.unity3d.com/ScriptReference/Animator.Play.html
            _dummyAnim.Play("Base Layer.pushed", 0, 0);
        }
        else
        {
            Debug.Log("Animator not assigned!");
        }
    }

    private void Die()
    {

    }
}
