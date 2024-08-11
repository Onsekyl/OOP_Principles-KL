using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _weapons;

    private void Start()
    {
        SelectWeapon(1);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            SelectWeapon(0);
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            SelectWeapon(1);
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            SelectWeapon(2);
        }
    }

    private void SelectWeapon(int weaponIndex)
    {
        for (int i = 0; i < _weapons.Length; i++)
        {
            _weapons[i].SetActive(false);
        }

        _weapons[weaponIndex].SetActive(true);
    }
}
