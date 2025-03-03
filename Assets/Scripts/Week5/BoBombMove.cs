using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BoBombMove : MonoBehaviour
{
    public List<Cannonball> cannonBall = new List<Cannonball> ();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannonBall = FindObjectsByType<Cannonball>(FindObjectsSortMode.None).ToList();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach(Cannonball ball in cannonBall)
            {
                ball.AddRandomForce();
            }
        } 
    }
}
