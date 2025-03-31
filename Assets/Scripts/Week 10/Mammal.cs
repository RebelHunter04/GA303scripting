using UnityEngine;

public class Mammal : Animal
{
    protected virtual void Start()
    {
        bType = BloodType.WarmBlooded;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Eat(int energyGained)
    {
        Debug.Log("Chomp Chomp Eating with my mouth");
        base.Eat(energyGained);
    }
    public virtual void GiveBirth()
    {
        Debug.Log("giving birth to a Mammal");
    }
}
