using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleModeInit : MonoBehaviour
{
    List<GameObject> tiles;

    public int xDim = 10;
    public int yDim = 10;
    void Awake()
    {
        tiles = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Init()
    {
        //Temp grid creation logic
        for (int i = 0; i < xDim; i++)
        {
            for (int j = 0; j < yDim; j++)
            {
                CreateTile(i, j);
            }
        }
        //



    }

    void CreateTile(int x, int y)
    {
        GameObject tile = GameObject.CreatePrimitive(PrimitiveType.Cube);
        tile.AddComponent(typeof(Tile));
        tile.transform.position = new Vector3(x, 0, y);
        tile.name = "Tile " + (x * yDim + y).ToString();
        tiles.Add(tile);
    }
}
