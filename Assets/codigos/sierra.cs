using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sierra : herenciadevelocidad
{
    private Rigidbody2D rigibody2D_;
    private Transform comTransform;
    public float speed = 4;
    public string nametag = "pared de arriba";
    public string nametag1 = "pared de abajo";
    public string nametag2 = "bloquedearriba";
    public string nametag3 = "bloquedeabajo";

    void Start()
    {
        rigibody2D_ = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rigibody2D_.linearVelocity = new Vector2(speed * speedy, speed * speedx);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == nametag || collision.gameObject.tag == nametag3)
        {
            speedy *= -4;
        }
        else if (collision.gameObject.tag == nametag1 || collision.gameObject.tag == nametag2)
        {
            speedy *= 4;
        }
    }
}
