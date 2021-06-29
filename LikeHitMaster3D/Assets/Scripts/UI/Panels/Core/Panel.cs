using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour, IPanel
{
    [SerializeField] private EPanelName ePanelName;

    public virtual EPanelName GetName()
    {
        return ePanelName;
    }

    public virtual void Off()
    {
        gameObject.SetActive(false);
    }

    public virtual void On()
    {
        gameObject.SetActive(true);
    }
}
