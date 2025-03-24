using Unity.VisualScripting;
using UnityEngine;

public class BooHide : MonoBehaviour
{
    
    private float tDelay = 3f;
    private float tRand = Random.Range(5f, 10f);
    public GameObject booGhost;
    public GenerateEnemies HideThis;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        booGhost.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

       tDelay += Time.deltaTime;
     //   hidethis.booghost.hide
       //every 5 to 10(rand) secs hide ghost for 1 sec  
       
     //if (tDelay += tRand)
        {
            booGhost.SetActive(false);
        }
    }
}
