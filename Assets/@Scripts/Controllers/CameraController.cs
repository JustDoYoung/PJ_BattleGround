using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform follow;
    [SerializeField] Transform lookAt;

    CinemachineFreeLook cm;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        cm = transform.GetComponentInChildren<CinemachineFreeLook>();

        follow = Managers.GameMananger.Player.transform;
        lookAt = follow.Find("HeadTarget");

        UpdateCameraSettings();
    }

    void UpdateCameraSettings()
    {
        cm.Follow = follow;
        cm.LookAt = lookAt;
    }
}
