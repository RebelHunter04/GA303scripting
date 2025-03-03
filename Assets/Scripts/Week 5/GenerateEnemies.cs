using System.Collections;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject booGhostPrefab;
    public int xPos;
    public int zPos;
    public int enemyCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // foreach(Booghost ghost in booGhost)
            {
                xPos = Random.Range(875, 895);
                zPos = Random.Range(1920, 1939);
                Instantiate(booGhostPrefab, new Vector3(xPos, 43, zPos), Quaternion.identity);
            }
        }
        //Find how many enemies you're going to spawn with Random.Range

        //Make that number part of the conditional part of the for loop so it spawns that many

        //PUT THE FOLLOWING IN A FOR LOOP
        /*
        xPos = Random.Range(875, 895);
        zPos = Random.Range(1920, 1939);
        Instantiate(booGhostPrefab, new Vector3(xPos, 43, zPos), Quaternion.identity);
        */
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
