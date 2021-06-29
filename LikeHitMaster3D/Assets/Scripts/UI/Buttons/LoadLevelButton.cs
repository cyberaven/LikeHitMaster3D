using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LoadLevelButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private int levelId = 0;

    public delegate void LoadLevelButtonDel(int levelId);
    public static event LoadLevelButtonDel LoadLevelButtonEve;

    public void OnPointerClick(PointerEventData eventData)
    {
        LoadLevelButtonEve?.Invoke(levelId);
    }
}
