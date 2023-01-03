using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    public string username;
    public string highscoreUser;
    public int highscore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadAll();
    }

    [System.Serializable]
    class SaveData
    {
        public string highscoreUser;
        public int highscore;
    }

    public void SaveAll()
    {
        SaveData data = new SaveData();
        data.highscoreUser = highscoreUser;
        data.highscore = highscore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadAll()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highscoreUser = data.highscoreUser;
            highscore = data.highscore;
        }
    }

    public void ClearAll()
    {
        highscoreUser = "Default";
        highscore = 0;
        SaveAll();
    }
}
