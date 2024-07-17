using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    GameObject _player;
    public GameObject Player { get { InitPlayer(); return _player; } }

    void InitPlayer()
    {
        if (_player == null)
        {
            _player = Spawn("Player");
        }
    }

    public  GameObject Spawn(string path, Transform parent = null)
    {
        GameObject go = Managers.Resource.Instantiate(path, parent);

        return go;
    }
}
