using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int CountDownNum;
    public int goalNum = 0;
    public Text numberText;
    public GameObject GameOverScene;
    public bool moveableCat = true;
    void Start()
    {
        CountDownNum = 15;
    }
    void Update()
    {
        if (CountDownNum == goalNum)
        {
            Debug.Log("BOOOOOm rick jumpscare NOW");
            GameOver();
            moveableCat = false;
        }
    }

    [ContextMenu("Decrease Score")]
    public void addScore()
    {
        CountDownNum -= 1;
        numberText.text = "Moe Rick jump scare in: " + CountDownNum.ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void death()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        CountDownNum -= 5;
        Debug.Log(goalNum);
    }
    [ContextMenu("death")]
    public void GameOver()
    {
        GameOverScene.SetActive(true);
    }
}
