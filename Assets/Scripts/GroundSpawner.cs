
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
//[SerializeField] private GameObject groundTile;
    [SerializeField] private GameObject dinoTerrain;
    private Vector3 nextSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            SpawnTile();
        }
    }

   public void SpawnTile()
    {
      //  GameObject temp =  Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        GameObject temp = Instantiate(dinoTerrain, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

}
