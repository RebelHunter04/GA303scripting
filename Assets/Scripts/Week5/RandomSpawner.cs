using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject cannonBallPrefab;

    void update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Vector3 randomSpawnPosition=new Vector3(Random.Range(-10,11),5, Random.Range(-10,11));
            Instantiate(cannonBallPrefab, randomSpawnPosition, Quaternion.identity);
        }
    }
}
