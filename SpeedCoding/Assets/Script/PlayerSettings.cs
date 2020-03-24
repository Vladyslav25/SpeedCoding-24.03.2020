using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSettings", menuName = "Player/Settings", order = 2)]
public class PlayerSettings : ScriptableObject
{
    public int MovmentSpeed;
    public int RotationSpeed_X;
    public int RotationSpeed_Y;

    public int Cam_Y_Max_Degree;
    public int Cam_Y_Min_Degree;
}
