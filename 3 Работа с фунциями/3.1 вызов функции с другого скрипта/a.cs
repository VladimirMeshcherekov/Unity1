using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{
    // из скрипта a будем вызывать функцию из скрипта b который находится на другом обьекте
    GameObject b_object;

    void Start()
    {
        b_object.GetComponent<b>().func(); // обращаемся к объекту на котором находится скрипт
        //ищем компонент b (= название скрипта)
        // вызываем функцию func()
    }
}
