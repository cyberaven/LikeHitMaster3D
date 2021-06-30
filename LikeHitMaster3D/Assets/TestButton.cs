using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestButton : MonoBehaviour, IPointerClickHandler
{
    public delegate void BulletTouchNpcDel();
    public static event BulletTouchNpcDel BulletTouchNpcEve;

    public void OnPointerClick(PointerEventData eventData)
    {
        BulletTouchNpcEve?.Invoke();
    }
}
