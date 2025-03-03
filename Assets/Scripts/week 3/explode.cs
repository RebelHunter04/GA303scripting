using UnityEngine;

public class Explode : MonoBehaviour
{
    public GameObject objectPrefab;  
    public int numberOfObjects = 10; 
    public float spawnRadius = 5f;   
    public float forceStrength = 10f;
    public void explode()
    {
       
        for (int i = 0; i < numberOfObjects; i++)
        {
            
            Vector3 randomPosition = transform.position + Random.insideUnitSphere * spawnRadius;
          
            GameObject spawnedObject = Instantiate(objectPrefab, randomPosition, Quaternion.identity);
          
            Rigidbody rb = spawnedObject.GetComponent<Rigidbody>();
         
            if (rb != null)
            {
                Vector3 randomDirection = Random.insideUnitSphere;
                rb.AddForce(randomDirection * forceStrength, ForceMode.Impulse);
            }
        }
    }
}








