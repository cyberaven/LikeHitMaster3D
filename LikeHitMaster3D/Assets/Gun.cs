using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Transform bulletBornPoint;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosFar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.farClipPlane);
            Vector3 mousePosNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);
            Vector3 mousePosF = Camera.main.ScreenToWorldPoint(mousePosFar);
            Vector3 mousePosN = Camera.main.ScreenToWorldPoint(mousePosNear);
            Debug.DrawRay(mousePosN, mousePosF - mousePosN, Color.green);


        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    Debug.DrawRay(bulletBornPoint.position, Camera.main.transform.position, Color.green, 0.5f);
        //    RaycastHit hit;
        //    if(Physics.Raycast(ray, out hit))
        //    {
        //        var selection = hit.transform;
        //        Debug.Log(selection);
        //        Debug.Log(selection.gameObject);
        //    }
        }
    }   
}
