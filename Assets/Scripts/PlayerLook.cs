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
    private float _cameraClampDegrees;
    [SerializeField]
    private float _lookSensitivityScaler;

    private void Start()
    {
        _playerCamera = this.gameObject.transform.GetChild(0).GetComponent<Camera>();
    }

    private void Update()
    {
        // ABSTRACTION
        Look();
    }

    private void Look()
    {
        _lookInputX = Input.GetAxisRaw("Mouse X");
        _lookInputY = Input.GetAxisRaw("Mouse Y");
        _lookInput = new Vector2(_lookInputX, _lookInputY);

        _lookDirection += _lookInput * _lookSensitivityScaler;
        _lookDirection.y = Mathf.Clamp(_lookDirection.y, -_cameraClampDegrees, _cameraClampDegrees);

        _playerCamera.transform.localRotation = Quaternion.AngleAxis(-_lookDirection.y, Vector3.right);
        transform.localRotation = Quaternion.AngleAxis(_lookDirection.x, Vector3.up);
    }
}
