using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    float moveInput;
    private bool facingRight = true;
    private Rigidbody2D rb;
    public Animator animator;
    public Text Heart;
    public Text Bana;
    float life = 3f;
    float score = 0f;
    public Sound[] sounds;
    
    void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Play("gameaudio2");
        
    }

    void Update()
    {
        Bana.text = "x " + score.ToString("0");
        Heart.text = "x " + life.ToString("0");
        if( transform.position.y <= -7)
        {
            life = 0;
        }
        if (life <= 0)
        {
            Endgame();
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            score++;
            // Destroy(collision.gameObject);
            Play("coinpickup");
        }
       if (collision.gameObject.tag == "Bomb")
        {
            life--;
            Play("explosion");
        }

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        animator.SetFloat("run_speed", Mathf.Abs(moveInput));
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        //  Vector3 Scaler = transform.localScale;

        transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
    }

    void Endgame()
    {
        PlayerPrefs.SetFloat("score", score);
        SceneManager.LoadScene(2);
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
            return;
        s.source.Play();
    }

}
