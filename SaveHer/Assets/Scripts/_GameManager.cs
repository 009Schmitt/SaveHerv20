using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class _GameManager : MonoBehaviour
{
    public GameObject playerObj, restartButton;

    // Start is called before the first frame update
    void Start()
    {
        restartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void KillPlayer()
    {
        restartButton.SetActive(true);
        Destroy(playerObj);
    }
    public void EndStage()
    {
        string path = Application.dataPath + "/Save.txt";
        string text = File.ReadAllText(path);
        int stage = int.Parse(text.Split(':')[1]);
        //if (stage == 0)
        //{
        //    stage++;
        //}
        stage++;
        File.WriteAllLines(path, new string[] { $"Stage:{stage}" });
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadScene(1);
    }


}
