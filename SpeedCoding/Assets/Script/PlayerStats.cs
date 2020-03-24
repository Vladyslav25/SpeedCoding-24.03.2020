using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Player/Stats", order = 1)]
public class PlayerStats : ScriptableObject
{
    [HideInInspector]
    public bool isAlive = true;
    [HideInInspector]
    public bool haveStamina = true;

    [SerializeField]
    private float m_maxHp;
    [SerializeField]
    private float m_hp;
    [SerializeField]
    private float m_maxDmg = float.MaxValue;

    [SerializeField]
    private float m_maxStamina;
    [SerializeField]
    private float m_stamina;


    public float HP
    {
        get
        {
            return m_hp;
        }
        set
        {
            m_hp = DamageTaken(value);
        }
    }

    public float Stamina
    {
        get
        {
            return m_stamina;
        }
        set
        {
            m_stamina = AddStamina(value);
        }
    }

    private float AddStamina(float value)
    {
        float newStamina = m_stamina + value;
        if (newStamina >= m_maxStamina)
        {
            m_stamina = m_maxStamina;
            return m_maxStamina;
        }
        else if (newStamina < 0)
        {
            m_stamina = 0;
            haveStamina = false;
            return m_stamina;
        }
        if (!haveStamina)
            haveStamina = true;
        return newStamina;
    }

    private float DamageTaken(float value)
    {
        if (value <= m_maxDmg)
        {
            float newHP = m_hp - value;
            if (newHP < 0)
            {
                isAlive = false;
                return 0;
            }
            return newHP;
        }
        throw new Exception("Es wurde mehr Schaden gemchat als erlaubt!");
    }
}
