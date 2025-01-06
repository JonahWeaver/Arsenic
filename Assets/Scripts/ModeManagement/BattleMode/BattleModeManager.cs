using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleModeManager : XModeManager
{
    private struct BattleInfo
    {
        int enemyCount;
        int allyCount;
        int npcCount;
    }

    private List<Func<BattleInfo, bool>> winConditions;
    private List<Func<BattleInfo, bool>> loseConditions;
    private List<GameObject> tempTileObjects;

    private BattleInfo generalBattleInfo;

    public int xDim = 10;
    public int yDim = 10;
    public TurnManager turnManager;

    private List<GameObject> allUnitObjects;

    // Update is called once per frame
    void Update()
    {

    }

    void OnConditionsUpdate()
    {
        foreach (Func<BattleInfo, bool> winCondition in winConditions)
        {
            if (winCondition(generalBattleInfo))
            {
                OverworldModeManager overworldManager = gameObject.GetComponent<OverworldModeManager>();
                overworldManager.Activate();
            }
        }
        foreach (Func<BattleInfo, bool> loseCondition in loseConditions)
        {
            if (loseCondition(generalBattleInfo))
            {
                Debug.Log("YOU JUST FUCKING LOST!");
                return;
            }
        }
    }

    public override void Init()
    {
        base.Init();

        if(tempTileObjects == null)
        {
            tempTileObjects = new List<GameObject>();
        }

        TempCreateGrid();
        TempPlaceCharacters();
        turnManager = new TurnManager();
        turnManager.BeginBattle(allUnitObjects);
    }

    void TempCreateGrid()
    {
        for (int i = 0; i < xDim; i++)
        {
            for (int j = 0; j < yDim; j++)
            {
                GameObject tile = GameObject.CreatePrimitive(PrimitiveType.Cube);
                tile.AddComponent(typeof(Tile));
                tile.transform.parent = this.transform;
                tile.transform.localPosition = new Vector3(i, 0, j);
                tile.name = "Tile " + (i * yDim + j).ToString();
                tempTileObjects.Add(tile);
            }
        }
    }

    void TempPlaceCharacters()
    {
        allUnitObjects.Clear();
        foreach (GameObject unit in GameObject.FindGameObjectsWithTag("Player"))
        {
            TempPlaceCharacter(unit);
            allUnitObjects.Add(unit);
        }
        foreach (GameObject unit in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            TempPlaceCharacter(unit);
            allUnitObjects.Add(unit);
        }
        //foreach (GameObject unit in GameObject.FindGameObjectsWithTag("PC"))
        //{
        //    TempPlaceCharacter(unit);
        //}
        //foreach (GameObject unit in GameObject.FindGameObjectsWithTag("NPC"))
        //{
        //    TempPlaceCharacter(unit);
        //}
    }

    void TempPlaceCharacter(GameObject unit)
    {
        GameObject tileToPlace = null;
        Character unitCharacter = unit.GetComponent<Character>();
        float minDist = -1f;
        foreach(GameObject tileObject in tempTileObjects)
        {
            Tile tile = tileObject.GetComponent<Tile>();
            tile.FindInhab();
            if(tile.inhab == null)
            {
                float dist = Vector3.Distance(tile.transform.position,
                    unit.transform.position);
                if(dist<minDist || minDist == -1f)
                {
                    tileToPlace = tileObject;
                    minDist = dist;
                }
            }
        }
        if (tileToPlace == null) return;
        tileToPlace.GetComponent<Tile>().inhab = unitCharacter;
        unit.transform.position = new Vector3(
            tileToPlace.transform.position.x,
            tileToPlace.transform.position.y + 1.5f,
            tileToPlace.transform.position.z);


    }

    void OnFinishInitialization(BattleInfo battleInfo)
    {
        generalBattleInfo = battleInfo;
    }

    protected override void PivotCamera()
    {
        base.PivotCamera();


    }
}



