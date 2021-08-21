using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// OUTDATED, use MathHelper

public class NumberHelper : MonoBehaviour
{
    public static void Normalize(ref float value)
    {
        value = Normalize(value);
    }

    public static float Normalize(float value)
    {
        if (value > 0)
        {
            return 1;
        }
        if (value < 0)
        {
            return -1;
        }
        return 0;
    }

    public static bool InBounds(float number, float max, float min)
    {
        return (number >= min && number <= max);
    }

    public static bool InBounds(float number, float bound)
    {
        return InBounds(number, bound, -bound);
    }
}
