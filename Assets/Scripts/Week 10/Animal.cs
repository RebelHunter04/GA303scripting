using UnityEngine;
public enum BloodType
{
    ColdBlooded,
    WarmBlooded
}
public class Animal : MonoBehaviour
{
    public int health = 100;
    public int energy = 100;

    protected BloodType bType;
    public virtual void Eat(int energyGained)
    {
        energy += energyGained;
    }
}
