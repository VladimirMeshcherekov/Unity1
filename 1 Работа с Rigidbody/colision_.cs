using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision_ : MonoBehaviour
{
    private Rigidbody2D rb;
    public LayerMask ground; // использование слоя, аналог тега
    private Collider2D coll; // ссылка на поле Collider2D

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        coll = gameObject.GetComponent<BoxCollider2D>(); 
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && coll.IsTouchingLayers(ground)) 
            // если нажата кнопка пробел и коллайдер объекта касается объекта со слоем gnd
            // наш объект подпрыгивает, защита от двойного прыжка
        {
            rb.velocity = new Vector2(rb.velocity.x, 5);
        }

    }
}
