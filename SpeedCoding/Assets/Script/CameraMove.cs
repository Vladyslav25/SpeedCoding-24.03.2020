using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public PlayerSettings m_playerSettings;
    public Transform m_player;
    public Transform target;

    void Update()
    {
        Rotation();
    }

    private void FixedUpdate()
    {
        SetPos();
    }

    private void SetPos()
    {
        transform.position = target.position;
    }

    private void Rotation()
    {
        float X = Input.GetAxis("Mouse X") * m_playerSettings.RotationSpeed_X;
        float Y = Input.GetAxis("Mouse Y") * m_playerSettings.RotationSpeed_Y;

        m_player.transform.Rotate(0, -X, 0);

        transform.Rotate(Y, 0, 0);

        transform.RotateAround(m_player.localPosition, new Vector3(0, 1, 0), -X);
        transform.LookAt(m_player);
    }
}
