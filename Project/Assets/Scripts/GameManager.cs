using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isGameEnd = false;

    public float restartDelay;
    public GameObject ui;
    public void EndGame()
    {
        if(isGameEnd==false)
        {
            Debug.Log("Game Over");
            isGameEnd = true;
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void completeLevel()
    {
        ui.SetActive(true);
        Debug.Log("Completed Level");
    }
}
