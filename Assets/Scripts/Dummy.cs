using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    public int dummyHealth { get; private set; }

    [SerializeField]
    private Animator _dummyAnim;
    [SerializeField]
    private float _dummyDespawnWaitSeconds = 4.0f;

    private DummySpawner _dummySpawner;
    private WaitForSeconds _dummyDespawnWait;

    private void Awake()
    {
        dummyHealth = 100;
        _dummyDespawnWait = new WaitForSeconds(_dummyDespawnWaitSeconds);
        _dummySpawner = GameObject.Find("DummySpawner").GetComponent<DummySpawner>();
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
        if (dummyHealth > 0)
        {
            dummyHealth -= damage;

            if (dummyHealth <= 0)
            {
                StartCoroutine(DummyDeath());
            }

            // https://docs.unity3d.com/ScriptReference/Animator.Play.html
            _dummyAnim.Play("Base Layer.pushed", -1, 0); 
        }
    }

    IEnumerator DummyDeath()
    {
        _dummyAnim.SetTrigger("DieTrigger");
        yield return _dummyDespawnWait;
        _dummySpawner.DespawnRespawn(gameObject);
    }
}
