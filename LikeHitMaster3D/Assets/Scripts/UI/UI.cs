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
        canvas.worldCamera = Camera.main;
    }

    public void PanelOn(EPanelName ePanelName)
    {
        foreach (Panel panel in panels)
        {
            if(ePanelName == panel.GetName())
            {
                panel.On();
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
}
