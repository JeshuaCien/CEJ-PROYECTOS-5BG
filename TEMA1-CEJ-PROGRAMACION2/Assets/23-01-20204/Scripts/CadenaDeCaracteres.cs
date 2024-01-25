using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CadenaDeCaracteres : MonoBehaviour
{
    public bool Isprefab;
    public GameObject prefab;
    public string data = "x:2 , y:5 , z:8";
    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        // 1. recorremos toda nuestra cadena de string data = "x:2 , y:5 , z:8";
        for (int i = 0; i < data.Length; i++)
        {
            // 2. revisamos si el valor que esta en la posición data[i] == 'x' es igual.
            if (data[i] == 'x')
            {
                //3. Si, sí es el valor, se transfornma el character(data[i]) a entero=int
                int x = (int)char.GetNumericValue(data[i + 2]);

                // 4. Se almacena la información de x en nuestro Vector3.
                pos = new Vector3(x, pos.y, pos.z);
            }
            // 5. Se recorre toda la cadena hasta terminar de transformar los caracteres en cada letra que asignamos.
            if (data[i] == 'y')
            {
                int y = (int)char.GetNumericValue(data[i + 2]);
                pos = new Vector3(pos.x, y, pos.z);
            }

            if (data[i] == 'z')
            {
                int z = (int)char.GetNumericValue(data[i + 2]);
                pos = new Vector3(pos.x, pos.y, z);
            }
            
        }

        if (prefab != null)
        {
            Instantiate(prefab, pos, Quaternion.identity);
            Debug.Log("Se creo un jugador");
        }
    }
}
