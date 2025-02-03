using UnityEngine;

public class Strings_script3 : MonoBehaviour
{
    string fullSentence;
    string intro; //= "Hey! what are you doing??"
    string mid; //= "You over there!"
    string outro; //= "Stop right there!"
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fullSentence = intro + " " + mid + " " + outro; 
        Debug.Log(fullSentence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
