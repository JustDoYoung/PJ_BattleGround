using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseScene : MonoBehaviour
{
    private GameObject _player;
    private CameraController _cameraController;

    public GameObject Player { get { return _player; } protected set { _player = value; } }
    public CameraController CameraController { get { return _cameraController; } protected set { _cameraController = value; } }

    private void Awake()
    {
        Init();
    }

    protected virtual void Init()
    {
        print("Base Scene");
        Managers.SceneManager.CurrentScene = GameObject.FindObjectOfType<BaseScene>();
        CameraController = GameObject.FindObjectOfType<CameraController>();
    }
}
