using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerEx
{
    private BaseScene _currentscene;
    public BaseScene CurrentScene { get { return _currentscene; } set { _currentscene = value; } }

    public void Clear()
    {
        CurrentScene = null;
    }
}
