using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public Button ButtonPrefab;
    // private Button[] levels;

    public GridLayoutGroup grid;
    // Start is called before the first frame update
    void Start()
    {
        int progress = PlayerPrefs.GetInt("progress");
        int levelNumber = SceneManager.sceneCountInBuildSettings;
        // levels = new Button[levelNumber];
        for(int i=2; i<levelNumber; i++)
        {
            Button levelButton = Instantiate(ButtonPrefab);
            levelButton.GetComponentInChildren<Text>().text = "|"+ (i-1) +"|";
            levelButton.transform.SetParent(grid.transform, false);
            Debug.Log(i);
            int level = i;
            levelButton.onClick.AddListener(() => {SceneManager.LoadScene(level);Debug.Log(SceneManager.GetActiveScene().buildIndex);});
            if(!(i<=progress))
            levelButton.interactable = false;
        }
    }
}
