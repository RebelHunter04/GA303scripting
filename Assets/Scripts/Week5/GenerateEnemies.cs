using System.Collections;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject cannonBallPrefab;
    public int xPos;
    public int zPos;
    public int enemyCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 30)
        {
            xPos = Random.Range(875, 895);
            zPos = Random.Range(1920, 1939);
            Instantiate(cannonBallPrefab, new Vector3(xPos, 43, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
