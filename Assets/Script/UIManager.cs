using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    [SerializeField]private string sceneName;
    public void Play()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void CustomizeMenu()
    {
        SceneManager.LoadScene(2);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
