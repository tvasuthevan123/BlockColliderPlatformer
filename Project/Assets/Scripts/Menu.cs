using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Begin()
    {
        PlayerPrefs.SetInt("progress", 2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
