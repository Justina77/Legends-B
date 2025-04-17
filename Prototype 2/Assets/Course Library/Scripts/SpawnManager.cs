using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosZ = 20;
    private float spawnRangeX = 10;
    private float startDelay = 2;
    private float repeatRate = 1.5f;
    void Start()
    {
        InvokeRepeating("spawnRandomAnimal", startDelay, repeatRate);
    }
    
    
    // Update is called once per frame
   // void Update()
  //  {
  //      if (Input.GetKeyDown(KeyCode.S))
   //     {
   //         spawnRandomAnimal();
   //     }
  //  }

    void spawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(
            Random.Range(-spawnRangeX,spawnRangeX),
            0,
            spawnPosZ);

        Instantiate(
            animalPrefabs[animalIndex],
            spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}