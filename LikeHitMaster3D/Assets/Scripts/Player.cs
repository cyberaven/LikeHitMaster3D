using System.Collections;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private Transform cameraPoint;

    public void SetCamera(Camera camera)
    {
        camera.transform.SetParent(transform);
        camera.transform.position = cameraPoint.transform.position;
        camera.transform.rotation = cameraPoint.transform.rotation;
    }
}
