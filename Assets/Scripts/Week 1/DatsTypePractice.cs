using System.Xml.Schema;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class DatsTypePractice : MonoBehaviour
{
    int santaClaus;

    float total;
    public float mario;
    public float yoshi = 4.8f;

    char bee = 'B';

    string fullSentance;
    string intro = "Hello World!";
    string outro = "Cya Later";

    public string chestName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        santaClaus = 56;

        santaClaus = (santaClaus + 5) * 2 / (3 - 7);

        Debug.Log(santaClaus);

        Debug.Log(yoshi);

        yoshi = yoshi - 2;

        Debug.Log(yoshi);

        Debug.Log("yoshi's value is " + yoshi);

        Debug.Log(bee + intro);

        total = mario + yoshi;

        Debug.Log(total);

        fullSentance = intro + " " + outro;


    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
