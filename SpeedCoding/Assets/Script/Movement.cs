using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
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

    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_playerRig.AddForce(transform.forward * m_playerSettings.MovmentSpeed);
        }
    }
}
