using System;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    [SerializeField] private Tile tilePrefab;
    [SerializeField] private float tileSpacing = 1.0f;
    
    [Header("Debug")]
    [SerializeField] private int xTilesCount;
    [SerializeField] private int zTilesCount;
    
    private bool tilesGenerated = false;

    private void Start()
    {
        GenerateTiles(xTilesCount, zTilesCount);
    }

    public void GenerateTiles(int xCount, int zCount, Transform parent = null)
    {
        if(tilesGenerated) return;

        for (int x = 0; x < xCount; x++)
        {
            for (int z = 0; z < zCount; z++)
            {
                Vector3 spawnPosition = new Vector3(x * tileSpacing, 0f, z * tileSpacing);
                Tile newTile = Instantiate(tilePrefab, spawnPosition, Quaternion.identity);
                //reparenting if needed
                if (parent == null)
                {
                    newTile.transform.SetParent(this.transform);
                }
                else
                {
                    newTile.transform.SetParent(parent);
                }
            }
        }
        
        tilesGenerated = true;
    }
}
