using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class input : MonoBehaviour, IPointerClickHandler 
{
   //IPointerClickHandler - интерфейс который отвечает за нажатие мышкой по объекту
   
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            // if работает пока нажата кнопка A (в тч и удерживается)
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            //if работает когда была нажата кнопка A (нажата, единожды)
        }
        
        if (Input.GetKeyUp(KeyCode.A))
        {
            //if работает когда была отпущена кнопка A (отпущена, единожды)
        }
        
    }

    public void OnPointerClick(PointerEventData eventData) 
    {
        // метод который выполняется когда произошло нажатие мышкой по объекту
        //обязательно на объекте должен быть collider, на сцене EventSystem (В UI находится)
        // на камере обязательно находится PhysicsRaycaster
    }
}
