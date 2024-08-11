using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 _moveInput;
    private float _moveInputZ;
    private float _moveInputX;
    private Vector2 _lookInput;
    private float _lookInputX;
    private float _lookInputY;


    [SerializeField]
    private float _movementSpeed;

    private void Start()
    {
        
    }

    private void Update()
    {
        Move();
        Look();
    }

    private void Move()
    {
        _moveInputZ = Input.GetAxisRaw("Vertical");
        _moveInputX = Input.GetAxisRaw("Horizontal");

        _moveInput = new Vector3(_moveInputX, 0, _moveInputZ).normalized;

        transform.Translate(_moveInput * _movementSpeed * Time.deltaTime);
    }

    private void Look()
    {
        _lookInputX = Input.mousePosition.x;
        _lookInputY = Input.mousePosition.y;

        _lookInput = new Vector2(_lookInputX, _lookInputY);

        transform.Rotate(_lookInput * Time.deltaTime);
    }
}
