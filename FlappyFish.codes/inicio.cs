using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inicio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void chamacenojogo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("CHOOSE_FISH");

    }
    public void options()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Options");
    }

    public void exit()
    {
        Application.Quit();
    }

}
