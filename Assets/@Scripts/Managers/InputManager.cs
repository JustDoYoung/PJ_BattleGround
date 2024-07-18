using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    public Action<Vector3> MovementAction = null;

    public void OnUpdate()
    {
        Movement();
    }

    void Movement()
    {
        if (MovementAction == null) return;

        float dirX = Input.GetAxis("Horizontal");
        float dirZ = Input.GetAxis("Vertical");
        
        Vector3 dir = new Vector3(dirX, 0, dirZ);

        MovementAction.Invoke(dir);
    }

    public void Clear()
    {
        MovementAction = null;
    }
}
