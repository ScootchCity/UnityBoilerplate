using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenuTransition : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("2DPlatformer_Game");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
