using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [Header("CLASE BASE")]
    public string Name = "Animal";
    public float speed = 5f;
    public Vector3 posicionMouse;

    public virtual void move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Posición del mouse.
            posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posicionMouse.z = 0f;

        }

        // Calcular la dirección y normalizarla.
        Vector2 direction = (posicionMouse - transform.position).normalized;

        //Mover al objeto a la dirección calculada.
        transform.Translate(direction * speed * Time.deltaTime);
    }


    public virtual void Display()
    {
        Debug.Log("El nombre del animal es :" + Name);
    }

    
}
