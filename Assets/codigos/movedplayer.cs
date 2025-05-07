using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedplayer : herenciadevelocidad
{
    private Rigidbody2D _compRigidbody2D;
    private SpriteRenderer _comSpriteRenderer;


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
}
