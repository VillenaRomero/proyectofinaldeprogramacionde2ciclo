using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class movedplayer : herenciadevelocidad
{
    private Rigidbody2D _compRigidbody2D;
    private SpriteRenderer _comSpriteRenderer;
    public string nametag = "puerta";
    public string nametag2 = "sierra";
    public string nivel;
    public string nivel2;

    private void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _comSpriteRenderer = GetComponent<SpriteRenderer>();

    }
    void Start()
    {

    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal > 0)
        {
            _comSpriteRenderer.flipX = false;
        }
        else if (horizontal < 0)
        {
            _comSpriteRenderer.flipX = true;
        }

        if (vertical > 0)
        {
            _comSpriteRenderer.flipY = false;
        }
        else if (vertical < 0)
        {
            _comSpriteRenderer.flipY = true;
        }
        _compRigidbody2D.linearVelocity = new Vector2(speedx * horizontal, speedy * vertical);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == nametag)
        {
            SceneManager.LoadScene(nivel);
        }
        if (collision.gameObject.tag == nametag2)
        {
            SceneManager.LoadScene(nivel2);
        }
    }
}
