using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class func : MonoBehaviour
{
    private int a, b, c; // 3 переменные
    void Update()
    {
        if (a > b)
        {
            // условие выполнится если a>b
        }

        if (a > b && a > c)
        {
            // условие выполнится если a > b и в тоже время a > c (&& значит и)
        }

        if (a > b || a > c)
        {
            // условие выполнится если a > b или в тоже время a > c (|| значит или)
        }

    }
}
