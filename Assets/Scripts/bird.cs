using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class bird : MonoBehaviour
{
    bool isded;
    Rigidbody2D rb2d;
    public float speed = 40f;
    public GameObject replaybutton;
    public GameObject playbutton;
    public TextMeshProUGUI scoreText;

    [SerializeField]
    private float flapforce = 200f;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        
        rb2d = GetComponent<Rigidbody2D>();
        //rb2d.velocity = Vector2.right * speed * Time.deltaTime;
        replaybutton.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        isded = true;
        rb2d.velocity = Vector2.zero;
        //replaybutton.SetActive(true);

        GetComponent<Animator>().SetBool("isded", true);
    }

    int score = 0;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Score")
        {
            score++;
            Debug.Log(score);
            scoreText.text = score.ToString();
        }
    }

    public void replay()
    {
        SceneManager.LoadScene(0);
    }

    public void unfreeze()
    {
        Time.timeScale = 1;
        playbutton.SetActive(false);
        rb2d.velocity = Vector2.right * speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isded)
        {
            rb2d.velocity = Vector2.right * speed * Time.deltaTime;
            rb2d.AddForce(Vector2.up * flapforce);
        }

        if (isded)
            replaybutton.SetActive(true);
    }
}
