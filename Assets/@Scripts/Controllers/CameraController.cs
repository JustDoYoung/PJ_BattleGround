using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform follow;
    [SerializeField] Transform lookAt;

    CinemachineFreeLook cm;

    private Camera _camera;
    public Camera MainCamera { get { return _camera; } }

    public void SetPlayer(GameObject player)
    {
        _camera = Camera.main;
        cm = transform.GetComponentInChildren<CinemachineFreeLook>();

        follow = player.transform;
        lookAt = follow.Find("HeadTarget");

        cm.Follow = follow;
        cm.LookAt = lookAt;
    }
}
