using System;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    [SerializeField] private Tile tilePrefab;
    [SerializeField] private float tileSpacing = 1.0f;
    [SerializeField] private List<GameObject> tileSetPrefabsList = new List<GameObject>();
    [SerializeField] private int maxTileSetPerRoom = 5;
    
    [Header("Debug")]
    [SerializeField] private int xTilesCount;
    [SerializeField] private int zTilesCount;
    
    private bool tilesGenerated = false;
    private Dictionary<Vector2Int, Tile> tiles = new Dictionary<Vector2Int, Tile>();


    public void GenerateRoom()
    {
        int randomIndex = UnityEngine.Random.Range(0, maxTileSetPerRoom);

        for(int i = 0; i <= randomIndex; i++)
        {
            GenerateRandomTileSetPrefab();
        }
    }

    private void GenerateRandomTileSetPrefab()
    {
        if(tileSetPrefabsList.Count > 0)
        {
            int randomIndex = UnityEngine.Random.Range(0, tileSetPrefabsList.Count);

            GameObject selectedTileSetPrefab = tileSetPrefabsList[randomIndex];
        }
    }

    public void GenerateSpecifiedLengthWidthTiles(int xCount, int zCount, Transform parent = null)
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
