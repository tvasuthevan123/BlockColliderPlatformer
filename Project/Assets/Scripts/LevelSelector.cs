using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public Button ButtonPrefab;

    public GridLayoutGroup grid;
    // Start is called before the first frame update
    void Start()
    {
        int progress = PlayerPrefs.GetInt("progress");
        int levelNumber = SceneManager.sceneCountInBuildSettings;
        Debug.Log(levelNumber);  
        // levels = new Button[levelNumber];
        for(int i=2; i<levelNumber-1; i++)
        {
            Debug.Log(i);
            Button levelButton = Instantiate(ButtonPrefab);
            levelButton.GetComponentInChildren<Text>().text = (i-1).ToString();
            levelButton.transform.SetParent(grid.transform, false); 

            //Figure out why this is the way it is.
            levelButton.onClick.AddListener(() => {SceneManager.LoadScene(int.Parse(levelButton.GetComponentInChildren<Text>().text)+1);});
            if(!(i<=progress))
            levelButton.interactable = false;
        }
    }
}
