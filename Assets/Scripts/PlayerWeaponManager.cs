using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _weapons;

    private int _currentWeaponIndex;

    private void Start()
    {
        _currentWeaponIndex = 1;
        SelectWeapon();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            _currentWeaponIndex = 0;
            // ABSTRACTION
            SelectWeapon();
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            _currentWeaponIndex = 1;
            SelectWeapon();
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            _currentWeaponIndex = 2;
            SelectWeapon();
        }

        if (Input.mouseScrollDelta.y > 0)
        {
            _currentWeaponIndex++;

            if (_currentWeaponIndex >= _weapons.Length)
            {
                _currentWeaponIndex = 0;
            }

            SelectWeapon();
        }
        else if(Input.mouseScrollDelta.y < 0)
        {
            _currentWeaponIndex--;

            if(_currentWeaponIndex < 0)
            {
                _currentWeaponIndex = _weapons.Length - 1;
            }

            SelectWeapon();
        }
    }

    private void SelectWeapon()
    {
        for (int i = 0; i < _weapons.Length; i++)
        {
            _weapons[i].SetActive(false);
        }

        _weapons[_currentWeaponIndex].SetActive(true);
    }
}
