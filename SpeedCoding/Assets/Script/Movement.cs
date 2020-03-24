using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public PlayerStats m_playerStats;
    public PlayerSettings m_playerSettings;

    private Rigidbody m_playerRig;

    private void Start()
    {
        m_playerRig = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Update()
    {
        Rotation();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_playerRig.AddForce(transform.forward * m_playerSettings.MovmentSpeed);
        }
    }

    private void Rotation()
    {
        float X = Input.GetAxis("Mouse X") * m_playerSettings.RotationSpeed_X;
        float Y = Input.GetAxis("Mouse Y") * m_playerSettings.RotationSpeed_Y;

        transform.Rotate(0, X, 0);

        if(!(Camera.main.transform.eulerAngles.x + (-Y) > m_playerSettings.Cam_Y_Min_Degree && 
            Camera.main.transform.eulerAngles.x + (-Y) < m_playerSettings.Cam_Y_Max_Degree))
        {
            Camera.main.transform.RotateAround(transform.position, Camera.main.transform.right, -Y);
        }
    }
}
