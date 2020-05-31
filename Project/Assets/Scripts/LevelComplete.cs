using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void NextLevel()
    {
        if(PlayerPrefs.GetInt("progress", 2)==SceneManager.GetActiveScene().buildIndex)
        PlayerPrefs.SetInt("progress", PlayerPrefs.GetInt("progress", 3)+1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
