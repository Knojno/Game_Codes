using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selecaoPeixe : MonoBehaviour
{

    public GameObject tilapia;
    public GameObject pacu;
    public GameObject pintado;
    public GameObject bacalhau;
    private Vector3 CharacterPosition;
    private Vector3 Offscreen;
    private int CharacterInt = 1;
    private SpriteRenderer tilapiaRender, pacuRender, pintadoRender, bacalhauRender;
    private readonly string selectedCharacter = "SelectedCharacter";





    // Start is called before the first frame update

    void Awake()
    {
        CharacterPosition = tilapia.transform.position;
        Offscreen = pacu.transform.position;
        tilapiaRender = tilapia.GetComponent<SpriteRenderer>();
        pacuRender = tilapia.GetComponent<SpriteRenderer>();
        pintadoRender = tilapia.GetComponent<SpriteRenderer>();
        bacalhauRender = tilapia.GetComponent<SpriteRenderer>();
    }

    public void nextCharacter()
    {
        switch (CharacterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter, 1);
                tilapiaRender.enabled = false;
                tilapia.transform.position = Offscreen;
                pacu.transform.position = CharacterPosition;
                pacuRender.enabled = true;
                CharacterInt++;
                break;

            case 2:
                PlayerPrefs.SetInt(selectedCharacter, 2);
                pacuRender.enabled = false;
                pacu.transform.position = Offscreen;
                pintado.transform.position = CharacterPosition;
                pintadoRender.enabled = true;
                CharacterInt++;
                break;

            case 3:
                PlayerPrefs.SetInt(selectedCharacter, 3);
                pintadoRender.enabled = false;
                pintado.transform.position = Offscreen;
                bacalhau.transform.position = CharacterPosition;
                bacalhauRender.enabled = true;
                CharacterInt++;
                break;

            case 4:
                PlayerPrefs.SetInt(selectedCharacter, 4);
                bacalhauRender.enabled = false;
                bacalhau.transform.position = Offscreen;
                tilapia.transform.position = CharacterPosition;
                tilapiaRender.enabled = true;
                CharacterInt++;
                ResetInt();
                break;

            default:
                ResetInt();
                break;

        }
    }

    public void previousCharacter()
    {
        switch (CharacterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter, 3);
                tilapiaRender.enabled = false;
                tilapia.transform.position = Offscreen;
                bacalhau.transform.position = CharacterPosition;
                bacalhauRender.enabled = true;
                CharacterInt--;
                ResetInt();
                break;

            case 2:
                PlayerPrefs.SetInt(selectedCharacter, 4);
                pacuRender.enabled = false;
                pacu.transform.position = Offscreen;
                tilapia.transform.position = CharacterPosition;
                tilapiaRender.enabled = true;
                CharacterInt--;
                break;

            case 3:
                PlayerPrefs.SetInt(selectedCharacter, 1);
                pintadoRender.enabled = false;
                pintado.transform.position = Offscreen;
                pacu.transform.position = CharacterPosition;
                pacuRender.enabled = true;
                CharacterInt--;
                break;

            case 4:
                PlayerPrefs.SetInt(selectedCharacter, 2);
                bacalhauRender.enabled = false;
                bacalhau.transform.position = Offscreen;
                pintado.transform.position = CharacterPosition;
                pintadoRender.enabled = true;
                CharacterInt--;
                
                break;

            default:
                ResetInt();
                break;
        }
    }

    private void ResetInt()
    {
        if (CharacterInt >= 4)
        {
            CharacterInt = 1;
        }
        else
        {
            CharacterInt = 4;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void game()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("jogo");
    }

    public void BACK()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Tela_inicial");

    }

   








}




