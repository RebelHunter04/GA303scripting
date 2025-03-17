using Unity.VisualScripting;
using UnityEngine;

public class BooHide : MonoBehaviour
{
    
    private float tDelay = 3f;
    private float tRand = Random.Range(5f, 10f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       tDelay += Time.deltaTime;

       //every 5 to 10(rand) secs hide ghost for 1 sec  
       // if (Time.time > )
      // if (UICounter) 

    }
}
