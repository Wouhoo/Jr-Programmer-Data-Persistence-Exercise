using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }

    public void SaveUsername(string username)
    {
        MenuManager.Instance.username = username;
    }

    public void ClearData()
    {
        MenuManager.Instance.ClearAll();
    }

    public void Exit()
    {
        MenuManager.Instance.SaveAll();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
