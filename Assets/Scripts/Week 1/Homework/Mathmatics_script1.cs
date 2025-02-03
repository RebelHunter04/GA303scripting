using UnityEngine;

public class Mathmatics_script1 : MonoBehaviour
{
    int crazyHorse; 
    int blackCrow;
    int redSheep;
    int total;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        crazyHorse = 78;
        blackCrow = 56;
        redSheep = 25;
        total = (crazyHorse / redSheep) + blackCrow * redSheep - crazyHorse + blackCrow * redSheep;


        
        Debug.Log(crazyHorse); 
        Debug.Log(blackCrow);
        Debug.Log(redSheep);
        Debug.Log(total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
