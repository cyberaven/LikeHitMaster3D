using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelsManager : MonoBehaviour
{
    [SerializeField] private List<Level> levels;
    private Level currentLevel;


    public void LoadLevel(int id)
    {
        foreach (Level level in levels)
        {
            if(level.Id == id)
            {                
                DestroyLevel(currentLevel);
                currentLevel = Instantiate(level, transform);
            }
        }
    }

    private void DestroyLevel(Level level)
    {
        if(level != null)
        {
            Destroy(level.gameObject);
        }
    }
}
