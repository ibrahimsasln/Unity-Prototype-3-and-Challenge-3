using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new(25, 0, 0);
    private float startDelay = 2;
    private float repeatDelay = 2;
    private PlayerController playerControllerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SpawnObstacle()
    {
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        
    }
}
