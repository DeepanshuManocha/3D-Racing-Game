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
}
