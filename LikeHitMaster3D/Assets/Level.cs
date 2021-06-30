using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private int id;    
    public int Id { get => this.id; }

    [SerializeField] private Player player;
    [SerializeField] private Transform levelStart;
    [SerializeField] private List<WayPoint> wayPoints;
    private int curentWayPointId = 0;

    public delegate void PlayerTouchLastWayPointsDel();
    public static event PlayerTouchLastWayPointsDel PlayerTouchLastWayPointsEve;

    private void OnEnable()
    {
        TestButton.BulletTouchNpcEve += BulletTouchNpc;
        WayPoint.PlayerTouchWayPointEve += PlayerTouchWayPoint;
    }
    private void OnDisable()
    {
        TestButton.BulletTouchNpcEve -= BulletTouchNpc;
        WayPoint.PlayerTouchWayPointEve -= PlayerTouchWayPoint;
    }
    private void Awake()
    {
        player = Instantiate(player, transform);
        player.SetCamera(Camera.main);

        player.transform.position = levelStart.position;               
    }
    private void Start()
    {
        MovePlayerWayPoint(wayPoints[curentWayPointId].transform);
    }

    private void MovePlayerWayPoint(Transform transform)
    {
        player.MoveTo(transform);
    }
    private void MovePlayerToNextWayPoint()
    {
        curentWayPointId++;
        if(curentWayPointId == wayPoints.Count)
        {
            PlayerTouchLastWayPointsEve?.Invoke();
        }
        else
        {
            MovePlayerWayPoint(wayPoints[curentWayPointId].transform);
        }        
    }
    private void PlayerTouchWayPoint(WayPoint wayPoint)
    {
        if (wayPoint.enemyCount == 0)
        {
            MovePlayerToNextWayPoint();
        }
    }
    private void BulletTouchNpc()
    {
        if (wayPoints[curentWayPointId].enemyCount > 0)
        {
            wayPoints[curentWayPointId].enemyCount--;
        }
        if (wayPoints[curentWayPointId].enemyCount == 0)
        {
            MovePlayerToNextWayPoint();
        }        
    }
}
