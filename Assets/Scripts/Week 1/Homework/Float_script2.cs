using UnityEngine;

public class Float_script2 : MonoBehaviour
{
    float total;
    public float gunSmoke;
    public float boneHawk;
    public float outHouse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        total = gunSmoke + boneHawk - (gunSmoke * outHouse) / boneHawk + outHouse;  

        Debug.Log(gunSmoke);
        Debug.Log(boneHawk);
        Debug.Log(outHouse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
