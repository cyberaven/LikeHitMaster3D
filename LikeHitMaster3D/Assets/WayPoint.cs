using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    public int enemyCount = 0;

    public delegate void PlayerTouchWayPointDel(WayPoint wayPoint);
    public static event PlayerTouchWayPointDel PlayerTouchWayPointEve;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {            
            PlayerTouchWayPointEve?.Invoke(this);
        }
    }
}
