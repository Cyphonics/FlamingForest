using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    void Update()
    {    
        //if the remainingTime is above 0
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        //if the remainingTime is below 0
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            // GamerOver();
            timerText.color = Color.red;
            //Loads the scene EndScene
            SceneManager.LoadScene("EndScene");
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        //Changes the text of the timerText to the remainingTime
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
