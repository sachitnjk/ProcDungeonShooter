using UnityEngine;

[CreateAssetMenu(fileName = "WallTypesComposite", menuName = "TileWall/WallTypesComposite")]
public class Wall_CornersTypesCompositeSO : ScriptableObject
{
    [SerializeField] private GameObject topWallModel;
    [SerializeField] private GameObject rightWallModel;
    [SerializeField] private GameObject bottomWallModel;
    [SerializeField] private GameObject leftWallModel;
}
