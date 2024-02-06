using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseItem : MonoBehaviour
{
    
    public string Name;
    public int ID;
    public int life;
    public string descripcion;
    public string type;
    public Sprite icon;

    [HideInInspector]
    public bool pickedUp;

    private void Start()
    {
        
    }

    void Update()
    {
        
    }
}
