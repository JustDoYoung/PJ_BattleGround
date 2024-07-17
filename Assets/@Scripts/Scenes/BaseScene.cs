using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseScene : MonoBehaviour
{
    private GameObject _player;
    public GameObject Player { get { return _player; } protected set { _player = value; } }

    private void Awake()
    {
        Init();
    }

    protected virtual void Init()
    {
        print("Base Scene");
    }
}
