using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject Doof;
    public float scaleIncrease = .5f;
    public GameObject youDiedScreen;
    public Transform teleportTransform;
    public Vector3 rotationAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Doof.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;
        if (Doof.transform.localScale.x > 30)
        {
            youDiedScreen.SetActive(true);
        }
    }

    public void ResetDoof()
    {
        Doof.transform.localScale = Vector3.one;
        scaleIncrease += .5f;
    }
    public void RotateDoof()
    {
        //Doof.transform.Rotate(new Vector3(0f, 0f, -90f));
        Doof.transform.Rotate(rotationAmount);
    }
    public void TeleportDoof()
    {
        Doof.transform.position = teleportTransform.position;
    }
}