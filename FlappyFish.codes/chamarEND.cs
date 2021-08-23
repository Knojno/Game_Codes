using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chamarEND : MonoBehaviour
{
    public int highscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        highscore = Score.score;
        GetComponent<UnityEngine.UI.Text>().text = highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("CHOOSE_FISH");

    }

    public void exit_dois()
    {
        Application.Quit();
    }

}
