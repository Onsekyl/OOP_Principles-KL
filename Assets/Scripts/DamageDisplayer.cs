using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamageDisplayer : MonoBehaviour
{
    [SerializeField]
    private GameObject _damageTxtPrefab;

    private TextMeshProUGUI _damageTxt;

    private void Start()
    {
        _damageTxt = _damageTxtPrefab.GetComponent<TextMeshProUGUI>();
    }

    public void DisplayDamage(int damageToDisplay, GameObject receiverEnemy)
    {
        if (receiverEnemy.GetComponent<Dummy>().dummyHealth > 0)
        {
            _damageTxt.text = damageToDisplay.ToString();
            Instantiate(_damageTxtPrefab, gameObject.transform);
        }
    }
}
