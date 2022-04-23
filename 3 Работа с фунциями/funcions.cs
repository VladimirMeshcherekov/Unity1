using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funcions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int b1 = 0, b2 = 1; // 2 переменные
        
        Debug.Log(plus(b1, b2)); // обращаемся к функции plus и передаём ей b1 и b2
        //  функции они превращаются в a и b
        // по результату plus(b1, b2) получаем сумму b1 и b2
    }
    
    int plus(int a, int b) // функция plus, принимает в себя 2 переменные, a и b
    {
        //переменные  а и b существуют только в пределах данной функции
        return a + b; // возвращает значение a + b
    }

    void a1() // функция a1
    {
        //void - значит пустая и не требует возврата
    }

    int a2() // функция a2 тип int и требует возврат соответсвующего типа
    {

        return 0; // возвращает значение
    } 
    
    // наглядно

    
}
