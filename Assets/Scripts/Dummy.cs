using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    [SerializeField]
    private Animator _dummyAnim;
    [SerializeField]
    private float _dummyDespawnWaitSeconds = 4.0f;

    private int _dummyHealth = 100;
    public static WaitForSeconds _dummyDespawnWait;

    private void Start()
    {
        _dummyDespawnWait = new WaitForSeconds(_dummyDespawnWaitSeconds);
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
        if (_dummyHealth > 0)
        {
            _dummyHealth -= damage;

            if (_dummyHealth <= 0)
            {
                StartCoroutine(DespawnRespawn());
            }

            // https://docs.unity3d.com/ScriptReference/Animator.Play.html
            _dummyAnim.Play("Base Layer.pushed", -1, 0);
        }
    }

    IEnumerator DespawnRespawn()
    {
        _dummyAnim.SetTrigger("DieTrigger");
        yield return _dummyDespawnWait;
        Destroy(gameObject);
    }
}
