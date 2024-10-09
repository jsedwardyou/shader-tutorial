using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static UnityEngine.Mathf;

public static class FunctionLibrary
{
    public delegate float Function(float x, float t);
    public static Function GetFunction(int index) {
        if (index == 0) return Wave;
        else if (index == 1) return MultiWave;
        else return Ripple;
    }

    public static float Wave(float x, float t) {
        return Sin(PI * (x + t));
    }

    public static float MultiWave(float x, float t) {
        float y = Sin(PI * (x + t));
        y += Sin(2f * PI * (x + t)) * 0.5f;

        return y * (3f / 2f);
    }

    public static float Ripple(float x, float t) {
        float d = Abs(x);
        return d;
    }
}
