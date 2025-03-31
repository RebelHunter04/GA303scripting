using UnityEngine;

public class Dog : Mammal
{
    public string dogBreed;
    public bool hasFur;
    public GameObject dogSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Start();
    }
    public void InitializeDog(string breed, bool fur)
    {
        dogBreed = breed;
        hasFur = fur;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GiveBirth();
        }
    }
    public void Bark()
    {
        Debug.Log("BARK BARK BARK");
        Debug.Log("this wakes the neighbors");
    }
    public override void Eat(int energyGained)
    {
        GameObject go = Instantiate(dogSpawn);
        go.GetComponent<Dog>().InitializeDog("Chipoo", true);
    }
}
