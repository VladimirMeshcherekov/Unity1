using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbody_ : MonoBehaviour
{
    Rigidbody2D rb; // ссылка на поле Rigidbody2D
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>(); // получаем свойство RigidBody2D из обьекта
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true) // при нажатии на пробел
        {
            rb.velocity = new Vector2(rb.velocity.x, 5); 
            // "пинание" тела по вертикали со скоростью 5, компоненту x не трогаем
        }
        
    }
}
