using System.Collections;
using UnityEngine;

public class BooCorou : MonoBehaviour
{
    public GameObject booGhost;
    public float minTime = 5f;
    public float maxTime = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(ToggleActive());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ToggleActive()
    {
        booGhost.SetActive(true);
        yield return new WaitForSeconds(Random.Range(minTime, maxTime));
        booGhost.SetActive(false);
    }
}
