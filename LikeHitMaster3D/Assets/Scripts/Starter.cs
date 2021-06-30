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
        Level.PlayerTouchLastWayPointsEve += PlayerTouchLastWayPoints;
    }
    private void OnDisable()
    {
        LoadLevelButton.LoadLevelButtonEve -= LoadLevelButtonEve;        
        Level.PlayerTouchLastWayPointsEve -= PlayerTouchLastWayPoints;

    }

    private void Awake()
    {
        ui = Instantiate(ui);
        levelsManager = Instantiate(levelsManager);

        ui.AllPanelOff();
        ui.PanelOn(EPanelName.LoadLevelsBtnPanel);
    }
    private void PlayerTouchLastWayPoints()
    {
        ui.SetCamera(Camera.main);        
        ui.PanelOn(EPanelName.LoadLevelsBtnPanel);
        levelsManager.DestroyCurrentLevel();
    }
    private void LoadLevelButtonEve(int levelId)
    {
        ui.AllPanelOff();
        levelsManager.LoadLevel(levelId);
    }

    
}
