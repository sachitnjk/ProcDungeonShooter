using UnityEngine;
using UnityEngine.Serialization;

public class TileWall : MonoBehaviour
{
    [SerializeField] private GameObject wallModelParent;
    // [SerializeField] private Wall_CornersTypesCompositeSO wallTypesCompositeSO;

    public void SetWallParameters(WallType wallType, Vector3 position)
    {
        if (wallModelParent != null && wallType != null && position != null)
        {
            //Wall rotation check
            Quaternion wallRotation;
            if (wallType == WallType.Top || wallType == WallType.Bottom)
            {
                wallRotation = Quaternion.Euler(0, 90, 0);
            }
            else
            {
                wallRotation = Quaternion.Euler(0, 0, 0);
            }
            
            wallModelParent.transform.rotation = wallRotation;
            wallModelParent.transform.position = position;
            
            wallModelParent.gameObject.SetActive(true);
        }
    }
}
