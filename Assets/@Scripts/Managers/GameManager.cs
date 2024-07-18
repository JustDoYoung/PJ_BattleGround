using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    public GameObject Player { get { return Managers.SceneManager.CurrentScene.Player; } }
    public Camera MainCamera { get { return Managers.SceneManager.CurrentScene.CameraController.MainCamera; } }

    public  GameObject Spawn(string path, Transform parent = null)
    {
        GameObject go = Managers.Resource.Instantiate(path, parent);

        return go;
    }
}
