using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelSelector : MonoBehaviour
{
    public void LoadLevelSelect()
    {
        SceneManager.LoadScene(1);
    }
}
