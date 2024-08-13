using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _dummyPrefab;
    [SerializeField]
    private float _dummyRespawnWaitSeconds = 1.0f;

    private WaitForSeconds _dummyRespawnWait;

    private void Start()
    {
        _dummyRespawnWait = new WaitForSeconds(_dummyRespawnWaitSeconds);
    }

    public void DespawnRespawn(GameObject callerDummy)
    {
        // For some reason I could not call straightly to the coroutine
        // It ended at yield return when doing so, so the respawn waiter didn't work that way
        // I think it's related to the destruction of the caller object
        StartCoroutine(Actions(callerDummy));
    }

    IEnumerator Actions(GameObject callerDummy)
    {
        Vector3 spawnPos = callerDummy.transform.position;
        Quaternion spawnRot = callerDummy.transform.rotation;
        Destroy(callerDummy);

        yield return _dummyRespawnWait;
        Instantiate(_dummyPrefab, spawnPos, spawnRot);
        
        Debug.Log("Script ends.");
    }
}
