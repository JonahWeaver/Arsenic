using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTempGrid : MonoBehaviour
{
    public int xDim = 10;
    public int yDim = 10;

    // Start is called before the first frame update
    void Awake()
    {
        for(int i=0;i<xDim;i++)
        {
            for(int j=0;j<yDim;j++)
            {
                GameObject tile = GameObject.CreatePrimitive(PrimitiveType.Cube);
                tile.AddComponent(typeof(Tile));
                tile.transform.parent = this.transform;
                tile.transform.localPosition = new Vector3(i, 0, j);
                tile.name = "Tile " + (i*yDim + j).ToString();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
