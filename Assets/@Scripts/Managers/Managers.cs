using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers _instance;

    public static Managers Instance
    {
        get
        {
            Init();
            return _instance;
        }
    }
    private InputManager _input = new InputManager();
    private ResourceManager _resource = new ResourceManager();
    private GameManager _game = new GameManager();

    public static InputManager Input { get { return Instance._input; } }
    public static ResourceManager Resource { get { return Instance._resource; } }
    public static GameManager GameMananger { get { return Instance._game; } }


    private static void Init()
    {
        if(_instance == null)
        {
            Managers managers = GameObject.FindObjectOfType<Managers>();

            if(managers == null)
            {
                GameObject go = new GameObject("@Managers");
                managers = go.AddComponent<Managers>();
                DontDestroyOnLoad(go);
            }

            _instance = managers;
        }
    }

    private void Update()
    {
        _input.OnUpdate();
    }
}
