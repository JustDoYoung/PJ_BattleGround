using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager
{
    public T Load<T>(string path) where T : Object
    {
        return Resources.Load<T>(path);
    }
    
    public GameObject Instantiate(string path, Transform parent = null)
    {
        GameObject go = Object.Instantiate(Load<GameObject>($"Prefabs/{path}"), parent);
        go.name = path;

        return go;
    }
}
