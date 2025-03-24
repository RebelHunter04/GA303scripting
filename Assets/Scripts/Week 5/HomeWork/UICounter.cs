using TMPro;
using UnityEngine;

public class UICounter : MonoBehaviour
{
    public float timer = 30f;
    public TextMeshProUGUI timerText;
    public bool hasTimerFinished = false;
    private bool allowCounting;
    public UICounter counterScript;
    public GenerateEnemies EnemiesSpawned;
    public numbGuesser PlayerNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hasTimerFinished == false)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                hasTimerFinished = true;
                counterScript.allowCounting = false;
                timer = 0f;
            }
            timerText.text = Mathf.Ceil(timer).ToString("F0");
        }
        
       if(hasTimerFinished == true)
        {
            if(PlayerNumber.counter == EnemiesSpawned.enemyCount)
             {
                timerText.text = ("You Win");
             }
             else
             {
                timerText.text = ("Better Luck Next Time");
            }
        }
    }
}
