using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject booGhostPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Vector3 randomSpawnPosition=new Vector3(Random.Range(-10,11),5, Random.Range(-10,11));
            Instantiate(booGhostPrefab, randomSpawnPosition, Quaternion.identity);
        }
    }
}
