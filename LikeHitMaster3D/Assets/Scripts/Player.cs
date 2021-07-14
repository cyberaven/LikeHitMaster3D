using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private Transform cameraPoint;
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float rotationSpeed = 2f;

    private Transform movePoint;
    private bool moveEnable = false;

    private void OnEnable()
    {
        WayPoint.PlayerTouchWayPointEve += PlayerTouchWayPoint;
    }
    private void OnDisable()
    {
        WayPoint.PlayerTouchWayPointEve -= PlayerTouchWayPoint;
    }

   

    private void Update()
    {
        Move();
        LookAtNextWayPoint();
    }

    private void LookAtNextWayPoint()
    {
        Quaternion newRotation = Quaternion.LookRotation(movePoint.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, rotationSpeed * Time.deltaTime);
    }

    private void Move()
    {
        if(moveEnable)
        {
            transform.position = Vector3.Lerp(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
        }
    }
    public void SetCamera(Camera camera)
    {
        camera.transform.SetParent(transform);
        camera.transform.position = cameraPoint.transform.position;
        camera.transform.rotation = cameraPoint.transform.rotation;
    }
    public void MoveTo(Transform movePoint)
    {
        this.movePoint = movePoint;
        moveEnable = true;
    }
    private void PlayerTouchWayPoint(WayPoint wayPoint)
    {
        moveEnable = false;
    }
}
