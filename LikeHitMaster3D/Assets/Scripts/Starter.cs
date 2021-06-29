using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField] private UI ui;
    [SerializeField] private LevelsManager levelsManager;  


    private void OnEnable()
    {
        LoadLevelButton.LoadLevelButtonEve += LoadLevelButtonEve;
    }
    private void OnDisable()
    {
        LoadLevelButton.LoadLevelButtonEve -= LoadLevelButtonEve;
    }
    private void Awake()
    {
        ui = Instantiate(ui);
        levelsManager = Instantiate(levelsManager);

        ui.AllPanelOff();
        ui.PanelOn(EPanelName.LoadLevelsBtnPanel);
    }


    private void LoadLevelButtonEve(int levelId)
    {
        ui.AllPanelOff();
        levelsManager.LoadLevel(levelId);
    }

    
}
