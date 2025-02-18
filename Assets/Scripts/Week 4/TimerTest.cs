using UnityEngine;

public class TimerTest : MonoBehaviour
{
    public float timerCountingUp = 0f;
    public float timerMaxDuration = 3f;
    public bool hasFinishedTimer;
    public GameObject cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

  /*  // Update is called once per frame
    void Update()
    {
        if(hasFinishedTimer == false)
        {
            timerCountingUp += Time.deltaTime;
            //Debug.Log(timerCountingUp);
            if (timerCountingUp == timerMaxDuration)
            {
                Debug.Log("Reached End of Timer!");
            }
        }
        
    } */

    void Update()
    {
        timerCountingUp += Time.deltaTime;
        if(timerCountingUp >= timerMaxDuration)
        {
            Debug.Log("Reached End of Timer!");
            cube.transform.position += Vector3.right;
            timerCountingUp = 0;

        }
    }
}

