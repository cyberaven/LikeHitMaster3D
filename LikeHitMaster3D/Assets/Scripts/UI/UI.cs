using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private List<Panel> panels;

    private Canvas canvas;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
        SetCamera(Camera.main);
    }

    public void PanelOn(EPanelName ePanelName)
    {
        foreach (Panel panel in panels)
        {
            if(ePanelName == panel.GetName())
            {
                panel.On();
                SetCamera(Camera.main);
            }
        }
    }
    public void AllPanelOff()
    {
        foreach (Panel panel in panels)
        {
            panel.Off();            
        }
    }
    public void SetCamera(Camera camera)
    {
        camera.transform.SetParent(null);
        canvas.worldCamera = camera;
    }
}
