using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void StartGame()
    {
        string path = Application.dataPath + "/Save.txt";
        if(File.Exists(path))
        {
            File.Delete(path);
        }
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadScene(1);
    }

}
