using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [Header("Follow Camera Settings")]
    [SerializeField] private Vector3 _offset;
    [SerializeField] private Transform _target;

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    private void LateUpdate()
    {
        if (_target == null) return;
        transform.position = _target.position + _offset;
    }
}