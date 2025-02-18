using UnityEngine;

public class TimerCountDown : MonoBehaviour
{
    public float timerCountingDown = 5f;
    public float timerMaxDuration = 0f;
    public bool hasFinishedTimer;
    public GameObject cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void Update()
    {
        timerCountingDown -= Time.deltaTime;
        if (timerCountingDown <= 0)
        {
            Debug.Log("Reached End of Timer!");
            cube.transform.position += Vector3.right;
            timerCountingDown = 0;

        }
    }
}

