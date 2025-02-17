using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform FirePlace;
    public float BulletForce;
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            fire();
        }
    }
    void fire()
    {
        GameObject Bullet = Instantiate(BulletPrefab, FirePlace.position,FirePlace.rotation);
        Rigidbody rb = Bullet.GetComponent<Rigidbody>();
        rb.AddForce(FirePlace.forward * BulletForce, ForceMode.Impulse);
    }
}
