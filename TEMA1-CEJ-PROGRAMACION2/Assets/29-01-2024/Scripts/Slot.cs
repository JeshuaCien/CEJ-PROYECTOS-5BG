using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.EventSystems;

public class Slot : MonoBehaviour //, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public GameObject item;
    public string Name;
    public string type;
    public string descripcion;
    public int life;
    public int ID;
    public Image image;

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



    //[HideInInspector]
    //public Transform parentAfterDrag;

    //public void OnBeginDrag(PointerEventData evenData)
    //{
    //    Debug.Log("comenzo el drag");
    //    parentAfterDrag = transform.parent;
    //    transform.SetParent(transform.root);
    //    transform.SetAsLastSibling();
    //    image.raycastTarget = false;
    //}

    //public void OnDrag(PointerEventData evenData)
    //{
    //    Debug.Log("Dragging");
    //    transform.position = Input.mousePosition;
    //}

    //public void OnEndDrag(PointerEventData eventData)
    //{
    //    Debug.Log("termino el drag");
    //    transform.SetParent(parentAfterDrag);
    //    image.raycastTarget = true;
    //}
}
