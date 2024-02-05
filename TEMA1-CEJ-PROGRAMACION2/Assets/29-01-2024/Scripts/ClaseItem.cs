using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseItem : MonoBehaviour
{
    
    public string Name;
    public int ID;
    public int life;
    public string descripcion;
    public Sprite icon;

    [HideInInspector]
    public bool pickedUp;

    [HideInInspector]
    public bool equipped;

    [HideInInspector]
    public GameObject objManager;

    [HideInInspector]
    public GameObject object0;

    public bool playerObj;

    private void Start()
    {
        // Se conecta el object manager para que se encuentre mediante su tag.
        objManager = GameObject.FindWithTag("ObjectManager");

        // Se pregunta si el objeto que recoge el player es igual al que tiene.
        if (!playerObj)
        {
            // Tener referencia de todos los objetos que tenemos en el objeto.
            int allobjects = objManager.transform.childCount;

            // pasara por todos los objetos preguntando su tag
            for (int i = 0; i < allobjects; i++)
            {
                if (objManager.transform.GetChild(i).gameObject.GetComponent<ClaseItem>().life == life)
                {
                    object0 = objManager.transform.GetChild(i).gameObject;
                }
            }
        }
    }

    void Update()
    {
        if (equipped)
        {

        }
    }

    public void ItemUsage()
    {
        if (Name == "Ropa")
        {
            object0.SetActive(true);
            object0.GetComponent<ClaseItem>().equipped = true;
        }
    }
}
