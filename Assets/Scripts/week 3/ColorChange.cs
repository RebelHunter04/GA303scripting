using Unity.VisualScripting;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.tag == "cannonball")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

}
