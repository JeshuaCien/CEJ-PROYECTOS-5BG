using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public GameObject item;
    public string Name;
    public int life;
    public int ID;
    public string descripcion;

    public bool empty;
    public Sprite icon;

    public Transform slotIconGameObject;

    // Va a tomar al children de los slot para enviarlo en esa ubicación.
    private void start()
    {
        slotIconGameObject = transform.GetChild(0);
    }

    // Se obtiene el componente Image de la UI usando su paqueteria y se manda al image de los slots que creamos.
    public void UpdateSlot()
    {
        this.GetComponent<Image>().sprite = icon;
    }

    public void UsedItem()
    {

    }
}
