using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    int a; //Переменная типа int с именем a
    // Переменная типа int хранит только целое число

    float b; //Переменная типа float с именем b
    // Переменная типа float хранит дробное число
    
    string c; //Переменная типа string с именем c
    // Переменная типа string хранит текст

    GameObject d;  //Переменная типа GameObject с именем d
    // Переменная типа GameObject хранит объект
    
    // функция Start() запускается единожды
    void Start()
    {
        int a1 = 4;
        int a2 = 2;
        // сперва нужно обьявить переменные, а лишь потом считать
        Debug.Log(a1+a2); // пишет содержимое в скобках в консоли
        Debug.Log(a1-a2);
        Debug.Log(a1*a2);
        Debug.Log(a1/a2);
        
        int[] mass = new int[5]; // массив данных размером в 6 ячеек
        a1 = mass[2]; //a1 равна переменной в массиве с номером 3, нумерация идёт с 0
    }

    // Функция Update() выполняется циклично и как ей хочется
    void Update()
    {
        
    }

    // Функция FixedUpdate() выполняется циклично каждый кадр,
    // а не как хочется, в отличии от Update()
    void FixedUpdate() 
    {
        
    }
}
