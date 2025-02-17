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
    private void OnCollisionEnter(Collider otherObject)
    {
        Debug.Log(otherObject.gameObject.name);

        if (otherObject.gameObject.tag == "cannonball")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }

    }

}
