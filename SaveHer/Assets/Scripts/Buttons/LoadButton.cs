using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadButton : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadScene(1);
    }



}
