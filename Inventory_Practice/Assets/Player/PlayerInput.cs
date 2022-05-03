using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerController _playerController;
    private Vector2 _movementAxis;

    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _playerController.Interact();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _playerController.Escape();
        }

        _movementAxis = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        _playerController.Movement(_movementAxis);
    }
}
