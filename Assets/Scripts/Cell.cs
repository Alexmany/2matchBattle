using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Cell : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    public GameController gc;

    [Space]
    public bool pressed;

    [Space]
    public Sprite icon;
    public int id;

    [Space]
    public Image _icon;

    [Space]
    public Image button;
    public Sprite[] _sprites;

    public void Start()
    {
        _icon.sprite = icon;
        _icon.enabled = false;
        button.sprite = _sprites[1];
    }

    public void OnPointerDown(PointerEventData eventData)
    {        
        _icon.enabled = true;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {       
        button.sprite = _sprites[0];
    }

    public void OnPointerExit(PointerEventData eventData)
    {        
        button.sprite = _sprites[1];
    }
}
