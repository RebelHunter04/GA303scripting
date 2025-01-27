using UnityEngine;

public class movementscript : MonoBehaviour
{
    public Vector3 startingPosition;
    public Vector3 moveDirection;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // start is called when this object first exists in the scene and the game is loaded.
    void Start()
    {
        // prints out hello world 
        Debug.Log("Hello World");
        // moves selected object to start position 
        this.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += moveDirection * speed * Time.deltaTime; // multipy by time.deltaTime per second not by frame
        Debug.Log("AAAAHHHHH");
    }
}
