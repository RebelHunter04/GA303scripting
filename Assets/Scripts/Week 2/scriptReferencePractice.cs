using UnityEngine;

public class scriptReferencePractice : MonoBehaviour
{
    public doofInc DoofController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DoofController.scaleIncrease = 5f;
        DoofController.RotateDoof();
        DoofController.RotateDoof();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
