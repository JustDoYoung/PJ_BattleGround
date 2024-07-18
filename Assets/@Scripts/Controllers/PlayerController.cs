using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController cc;

    [SerializeField][Range(0f, 20f)] float MoveSpeed = 5f;
    [SerializeField] [Range(0f, 20f)] float RotateSpeed = 10f;

    private void Awake()
    {
        cc = transform.GetComponent<CharacterController>();
    }

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        Managers.Input.MovementAction -= UpdateMoving;
        Managers.Input.MovementAction += UpdateMoving;
    }

    private void UpdateMoving(Vector3 obj)
    {
        if(obj.magnitude > 0) UpdateRotate();

        Vector3 dir = Camera.main.transform.TransformDirection(obj);
        dir.Normalize();

        cc.SimpleMove(dir * MoveSpeed);
    }

    void UpdateRotate()
    {
        Vector3 dir = Camera.main.transform.forward;
        dir = Vector3.ProjectOnPlane(dir, Vector3.up);

        transform.forward = dir;
    }
}
