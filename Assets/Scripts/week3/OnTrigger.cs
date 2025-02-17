using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public Explode explode; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cyl")
        {
           explode.explode();
           Debug.Log(other.name + "has entered");
        }
       
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + "Has exited");
    }
}
