using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private int id;    
    public int Id { get => this.id; }

    [SerializeField] private Player player;
    [SerializeField] private Transform levelStart;

    private void Awake()
    {
        player = Instantiate(player, transform);
        player.SetCamera(Camera.main);

        player.transform.position = levelStart.position;
               
    }
}
