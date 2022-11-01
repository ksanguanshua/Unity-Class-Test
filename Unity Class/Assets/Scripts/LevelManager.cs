using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    Scene scene;

    void Awake()
    {
        scene = SceneManager.GetActiveScene();
    }

    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void selectLevel()
    {
        if(scene.buildIndex == 0)
        {
            SceneManager.LoadScene(1);
            scene = SceneManager.GetSceneByBuildIndex(1);
        }
        else if(scene.buildIndex == 1)
        {
            SceneManager.LoadScene(0);
            scene = SceneManager.GetSceneByBuildIndex(0);
        }
        
    }
}
