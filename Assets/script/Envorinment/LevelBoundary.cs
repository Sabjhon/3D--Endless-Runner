using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -3.3f;
    public static float rightSide = 2.8f;
    public float internalLeft;
    public float internalRight;
    

    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
