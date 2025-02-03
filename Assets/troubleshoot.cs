using UnityEngine;

public class troubleshoot : MonoBehaviour
{
    float total;
    public float gunSmoke;
    public float boneHawk;
    public float outHouse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(gunSmoke);
        Debug.Log(boneHawk);
        Debug.Log(outHouse);
        total = gunSmoke + boneHawk - (gunSmoke * outHouse) / boneHawk + outHouse;       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
