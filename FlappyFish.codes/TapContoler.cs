using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class TapContoler : MonoBehaviour
{
    public AudioSource audiotap;
    public float velocity = 1;
    public float Force = 1;
    public float Smooth = 5;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    Quaternion down;
    Quaternion Forward;
    public Sprite tilapia, pacu, bacalhau, pintado;
    private SpriteRenderer mySprite;
    private readonly string selectedCharacter = "SelectedCharacter";
    private void Awake()
    {
        mySprite = this.GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        down = Quaternion.Euler(0, 0, -90);
        Forward = Quaternion.Euler(0, 0, 35);
        int getCharacter;
        getCharacter = PlayerPrefs.GetInt(selectedCharacter);

        switch (getCharacter)
        {
            case 1:
                mySprite.sprite = pacu;
                break;

            case 2:
                mySprite.sprite = pintado;
                break;

            case 3:
                mySprite.sprite = bacalhau;
                break;

            case 4:
                mySprite.sprite = tilapia;
                break;
            default:
                mySprite.sprite = tilapia;
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
         
            transform.rotation = Forward;
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector2.up * Force, ForceMode2D.Force);
            rb.velocity = Vector2.up * velocity;
            audiotap.Play();
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, down, Smooth * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "deadzone")
        {
            Destroy(gameObject, 0.1f);
            UnityEngine.SceneManagement.SceneManager.LoadScene("END");

        }

    }

}

