using UnityEngine;

public class ListTest : MonoBehaviour
{
    //public ListTest<Cannonball> cannonballs = new ListTest<Cannonball>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //cannonballs = FindObjectsByType<Cannonball>(FindObjectsSortMode.None).ToList();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //foreach(Cannonball ball in cannonballs)
            {

            }
        }
    }
    public void AddRandomForce()
    {
        Vector3 randomDirection = Vector3.zero;
        randomDirection.x = Random.Range(0f, 1f);
        randomDirection.y = Random.Range(0f, 1f);
        randomDirection.z = Random.Range(0f, 1f);

        float forceMultiplier = Random.Range(100, 75); 
    }
}
