using UnityEngine;

public class KBall : MonoBehaviour
{
    public GameObject kBallPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(kBallPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(kBallPrefab);
    }
}
