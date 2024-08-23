
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    [SerializeField]  GameObject singleObstaclePrefab;
    [SerializeField] GameObject doubleObstaclePrefab;
    [SerializeField] GameObject downObstaclePrefab;
    [SerializeField] float doubleObstacleChance;
    [SerializeField] float downObstacleChance;

 
   

    // Start is called before the first frame update
    void Start()
    {
        
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 3);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {

   
        GameObject obstacleToSpawn = singleObstaclePrefab;
        float random = Random.Range(0f, 1f);

        if (random > doubleObstacleChance && random < downObstacleChance)
            obstacleToSpawn = doubleObstaclePrefab;


        if (random > downObstacleChance )
            obstacleToSpawn = downObstaclePrefab;

        Transform spawnPoint = transform.GetChild(2).transform;

        Instantiate(obstacleToSpawn, spawnPoint.position, Quaternion.identity, transform);
    }
}
