using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    private Vector2 _lookInput;
    private float _lookInputX;
    private float _lookInputY;

    [SerializeField]
    private float _lookSensitivity;

    private void Start()
    {
        
    }

    private void Update()
    {
        Look();
    }

    private void Look()
    {
        _lookInputX = Input.GetAxisRaw("Mouse X");
        _lookInputY = Input.GetAxisRaw("Mouse Y");

        _lookInput = new Vector2(_lookInputX, _lookInputY);

        transform.Rotate(_lookInput * _lookSensitivity * Time.deltaTime);
    }
}
