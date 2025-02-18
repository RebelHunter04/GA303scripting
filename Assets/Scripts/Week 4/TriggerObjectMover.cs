using UnityEngine;

public class TriggerObjectMover : MonoBehaviour
{
    public bool hasHitTrigger;
    public GameObject wall;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hasHitTrigger == true)
        {
            wall.transform.position += Vector3.right * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Cannonball")
        {
            hasHitTrigger = true;
        } 
    }
}
