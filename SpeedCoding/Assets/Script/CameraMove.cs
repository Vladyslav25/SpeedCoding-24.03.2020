﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public PlayerSettings m_playerSettings;
    public Transform m_player;

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }

    private void Rotation()
    {
        float X = Input.GetAxis("Mouse X") * m_playerSettings.RotationSpeed_X;

        m_player.transform.Rotate(0, -X, 0);

        transform.RotateAround(m_player.localPosition, new Vector3(0, 1, 0), -X);
        transform.LookAt(m_player);

    }
}
