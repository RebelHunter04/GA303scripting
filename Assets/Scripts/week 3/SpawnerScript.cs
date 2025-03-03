using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject cannonballPrefab;

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(cannonballPrefab,transform.position,Quaternion.identity);
        }

    }
}
