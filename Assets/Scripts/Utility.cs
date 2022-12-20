using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utility : MonoBehaviour
{
    public static Color DamageToColor(DamageType type)
    {
        if (type == DamageType.RED)
        {
            return Color.red;
        }

        if (type == DamageType.PURPLE)
        {
            return Color.magenta;
        }

        if (type == DamageType.YELLOW)
        {
            return Color.yellow;
        }

        if (type == DamageType.GREEN)
        {
            return Color.green;
        }

        if (type == DamageType.BLUE)
        {
            return Color.blue;
        }
        if (type == DamageType.BLACK)
        {
            return Color.black;
        }

        return Color.white;

    }
}
