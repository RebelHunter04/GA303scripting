using TMPro;
using UnityEngine;

public class numbGuesser : MonoBehaviour
{
    public TextMeshProUGUI numbtext;
    public int counter = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            CountUp();
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            CountDown();
        }
        if (counter < 0)
        {
            counter = 0; 
        }
    }
    void CountUp()
    {
        counter++;
    }
    
    void CountDown()
    {
        counter--;
    }

}

