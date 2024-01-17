using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOG : Animal
{
    [Header("CLASE DERIVADA")]
    public string Raza;

    // Start is called before the first frame update
    void Start()
    {
        //Name = "Pepe";
        Display();
    }

    public override void move()
    {
        // Posición del mouse.
        posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionMouse.z = 0f;



        // Calcular la dirección y normalizarla.
        Vector3 direction = (posicionMouse - transform.position).normalized;

        //Mover al objeto a la dirección calculada.
        transform.Translate(direction * speed * Time.deltaTime);
    }




    // Es llamado en cada frame.
    void Update()
    {
        move();
    }
}
