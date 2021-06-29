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
    [SerializeField] private List<Transform> wayPoints;

    private void Awake()
    {
        player = Instantiate(player, transform);
        player.SetCamera(Camera.main);

        player.transform.position = levelStart.position;               
    }
    private void Start()
    {
        MovePlayerToNextWayPoint(wayPoints[0]);        
    }

    private void MovePlayerToNextWayPoint(Transform transform)
    {
        player.MoveTo(transform);
    }
}
