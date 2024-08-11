using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 _moveInput;
    private float _moveInputZ;
    private float _moveInputX;

    [SerializeField]
    private float _movementSpeed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _moveInputZ = Input.GetAxisRaw("Vertical");
        _moveInputX = Input.GetAxisRaw("Horizontal");

        _moveInput = new Vector3(_moveInputX, 0, _moveInputZ).normalized;

        transform.Translate(_moveInput * _movementSpeed * Time.deltaTime);
    }
}
