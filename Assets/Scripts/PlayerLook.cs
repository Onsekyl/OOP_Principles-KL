using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    private Camera _playerCamera;

    private Vector2 _lookDirection;
    private Vector2 _lookInput;

    private float _lookInputX;
    private float _lookInputY;

    [SerializeField]
    private float _lookSensitivity;

    private void Start()
    {
        _playerCamera = this.gameObject.transform.GetChild(0).GetComponent<Camera>();
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

        _lookDirection += _lookInput;

        transform.localRotation = Quaternion.AngleAxis(_lookDirection.x * _lookSensitivity, Vector3.up);
        _playerCamera.transform.localRotation = Quaternion.AngleAxis(-_lookDirection.y * _lookSensitivity, Vector3.right);

    }
}
