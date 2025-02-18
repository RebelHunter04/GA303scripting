using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform FirePlace;
    public float BulletForce;

    public void FireOnTimer()
    {
        Invoke("fire", 0.5f);
    }
    void fire()
    {
        GameObject Bullet = Instantiate(BulletPrefab, FirePlace.position,FirePlace.rotation);
        Rigidbody rb = Bullet.GetComponent<Rigidbody>();
        rb.AddForce(FirePlace.forward * BulletForce, ForceMode.Impulse);
    }
}
