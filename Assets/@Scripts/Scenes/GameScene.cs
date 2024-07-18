using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : BaseScene
{
    protected override void Init()
    {
        base.Init();

        if(Player == null)
        {
            Player = Managers.GameManager.Spawn("Player");
        }

        CameraController.SetPlayer(Player);
    }
}
