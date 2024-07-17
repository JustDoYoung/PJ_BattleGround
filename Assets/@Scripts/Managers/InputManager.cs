using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    Transform _player;

    public Transform Player { get { InitPlayer(); return _player; } }

    void InitPlayer()
    {
        if(_player == null)
        {
            _player = Managers.GameMananger.Player.transform;
        }
    }

    public void OnUpdate()
    {
        Move();
        Rotate();
    }

    void Move()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Forward");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Back");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Right");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Left");
        }
    }

    void Rotate()
    {

    }
}
