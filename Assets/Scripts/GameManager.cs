using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    public static int Score = 0;
    public static int Lives = 3;
    public static int Floors = 0;

    public static Quaternion RopeQuaternion;
    public static float PositionX = 3.75f;
    public static float PositionY = 4.5f;
    public static void Reset()
    {
        Score = 0;
        Lives = 3;
        Floors = 0;
    }
}
