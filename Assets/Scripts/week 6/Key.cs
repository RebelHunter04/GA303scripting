using UnityEngine;

/* public class Key : MonoBehaviour
{
    public bool hasKey = false;
    public GameObject playerCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hitObject;

            if(Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hitObject, 10f))
            {
                if(hitObject.collider.gameObject.tag == "Door")
                {
                    if(hasKey == true)
                    {
                        //0penDoor
                       // hitObject.collider.gameObject.GetComponent<Door>().OpenDoor();
                    }
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
*/