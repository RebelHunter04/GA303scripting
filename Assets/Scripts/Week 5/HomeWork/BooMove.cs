using UnityEngine;

public class BooMove : MonoBehaviour
  
{
    public Rigidbody rbody;
    public Vector3 moveDir;
    public float speed = 4f;
    public float timer = 4f;
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        ChangeDirection();
    }

    void Update()
    {
        rbody.AddForce(moveDir * speed * Time.deltaTime);

                timer -= Time.deltaTime;
        if (timer <= 0)
        {
            ChangeDirection();
            timer = 2f;
        }
        
    }

    void ChangeDirection()
    {
        moveDir = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
    }
}
