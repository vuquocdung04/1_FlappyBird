using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BirdController : MonoBehaviour
{
    public Rigidbody2D bird_rb2d;
    public Transform bird_tran;
    public Animator bird_ani;

    public float speed;
    public float rotation_Speed;
    bool checkDie = false;

    public GameObject gameOver;
    public GameObject canVas;
    public TextMeshProUGUI currentScoreText;
    public int currentScore = 0;
    public GameObject pointCanvas;


    public GameObject Point_fly;

    // script

    private void Start()
    {
        bird_rb2d = GetComponent<Rigidbody2D>();
        bird_tran = GetComponent<Transform>();
        bird_ani = GetComponent<Animator>();

        Time.timeScale = 1.0f;
        gameOver.SetActive(false);
        canVas.SetActive(false);
    }
    void Update()
    {
        bird_rb2d.gravityScale = 1.2f;
        PlayBird();
        currentScoreText.text = currentScore.ToString();
    }
    private void FixedUpdate()
    {
        var bird = bird_rb2d.velocity.y * rotation_Speed;
        if (bird >= -90 && bird <= 90)
        {
            bird_tran.rotation = Quaternion.Euler(0,0,bird * rotation_Speed);
        }
        else
        {
            bird_tran.rotation = Quaternion.Euler(0,0,180);
        }
    }
    public void PlayBird()
    {

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && checkDie == false)
        {
            bird_rb2d.velocity = Vector2.up * speed;
            StartCoroutine(AnimScale());
        }
    }
    IEnumerator AnimScale()
    {
        float ramdomScale = Random.Range(1.1f,1.3f);

        bird_tran.localScale = new Vector3(ramdomScale,ramdomScale,1.2f);
        yield return new WaitForSeconds(0.15f);
        bird_tran.localScale = new Vector3(1,1,1);
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        canVas.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        currentScore++;
        Debug.Log("Score now: " + currentScore);
        Instantiate(Point_fly,new Vector2(this.transform.position.x, this.transform.position.y + 0.5f), Quaternion.identity);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(GamePause());
    }
    IEnumerator GamePause()
    {
        checkDie = true;
        bird_ani.Play("die");
        bird_rb2d.velocity = this.transform.position;
        yield return new WaitForSeconds(0.8f);
        Time.timeScale = 0f;
        GameOver();
    }

}
