using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class BooList : MonoBehaviour
{
    public List<GameObject> booGhost;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        booGhost[0].SetActive(false);

        booGhost[booGhost.Count - 1].SetActive(false);
        foreach (GameObject go in booGhost)
        {
            Debug.Log(go.name);
        }
        for (int i = 0; i < booGhost.Count; i++)
        {
           // if(3) 
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}