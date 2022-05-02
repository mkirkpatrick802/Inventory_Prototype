using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Basic Movement")]
    [SerializeField] private float _moveSpeed;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Movement(Vector2 movementAxis)
    {
        Vector2 _currentVelocity = _rb.velocity;
        Vector2 _targetVelocity = Vector2.ClampMagnitude(movementAxis * _moveSpeed, _moveSpeed * Time.deltaTime);
        Vector2 _velocityChange = _targetVelocity - _currentVelocity;
        _rb.AddForce(_velocityChange, ForceMode2D.Impulse);
    }
}
