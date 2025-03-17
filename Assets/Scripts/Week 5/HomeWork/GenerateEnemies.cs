using System.Collections;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject booGhostPrefab;
    public int xPos;
    public int zPos;
    public int enemyCount;
    public int Spawn; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawn = 1;
    }

    void Update()
    {
        if (Spawn == 1)
        {
            enemyCount = Random.Range(20, 40);
            for (int i = 1; i <= enemyCount; i++)
            {
                xPos = Random.Range(875, 895);
                zPos = Random.Range(1920, 1939);
                Instantiate(booGhostPrefab, new Vector3(xPos, 47, zPos), Quaternion.identity);
            }
            Spawn = 0;
        }
       


    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 30)
        {
            xPos = Random.Range(875, 895);
            zPos = Random.Range(1920, 1939);
            Instantiate(booGhostPrefab, new Vector3(xPos, 43, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1; 
        }
    }
}
