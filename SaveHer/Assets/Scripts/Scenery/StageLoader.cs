using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreateSaveNLoad();
    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    public void CreateSaveNLoad()
    {

        string path = Application.dataPath + "/Save.txt";
        print(path);

        if (!File.Exists(path))
        {
            File.WriteAllLines(path, new string[] { "Stage:2" });
        }

        string[] text = File.ReadAllLines(path);

        text = text[0].Split(':');
        int stageValue = int.Parse(text[1]);

        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        
        SceneManager.LoadScene(stageValue);


        //if (text[1] == "0")
        //{
        //    SceneManager.LoadScene(2);
        //}
        //else if (text[1] == "1")
        //{
        //    //SceneManager.UnloadSceneAsync(0);
        //    SceneManager.LoadScene(3);
        //}
    }
}
