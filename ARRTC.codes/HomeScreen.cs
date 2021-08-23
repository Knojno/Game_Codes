using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void CallGameScreen()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScreen");
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
}
