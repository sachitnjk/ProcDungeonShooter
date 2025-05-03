using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [Header("Tile wall spawn points")]
    [SerializeField] private Vector3 leftWallSpawnPoint;
    [SerializeField] private Vector3 rightWallSpawnPoint;
    [SerializeField] private Vector3 bottomWallSpawnPoint;
    [SerializeField] private Vector3 topWallSpawnPoint;
    
    [Header("Prefab References")]
    [SerializeField] private TileWall wallPrefab;
    
    public Vector3 LeftAttachmentPoint => leftWallSpawnPoint;
    public Vector3 RightAttachmentPoint => rightWallSpawnPoint;
    public Vector3 BottomAttachmentPoint => bottomWallSpawnPoint;
    public Vector3 TopAttachmentPoint => topWallSpawnPoint;
    
    private List<TileWall> _spawnedWallsList = new List<TileWall>();
    
}
