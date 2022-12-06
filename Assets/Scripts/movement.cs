using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private Sprite mySprite;
    private SpriteRenderer sr;

    private bool collidedEnemy = false;
    private bool collidedPill1 = false;
    private bool collidedPill2 = false;
    private bool collidedObj = false;
    private float timer = 0.0f;

    void Awake()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        //mySprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, 128.0f, 128.0f), new Vector2(0.5f, 0.5f), 100.0f);

        //sr.color = new Color(0.9f, 0.9f, 0.5f, 1.0f);
        //sr.sprite = mySprite;
        //transform.position = new Vector3(0.0f, -2.0f, 0.0f);
    }

    void FixedUpdate()
    {
        Vector2 vect = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (collidedEnemy)
        {
            timer = timer + Time.deltaTime;

            if(timer < 6)
            {
                rb2D.velocity = Vector2.zero;
            }
            else
            {
                collidedEnemy = false;
                timer = 0.0f;
            }
        }
        else if(collidedPill1)
        {
            timer = timer + Time.deltaTime;

            if(timer < 6)
            {
                float maxSpeed = 1.09f;

                //rb2D.velocity = new Vector2((rb2D.velocity.x) , (rb2D.velocity.y) );
                rb2D.velocity = rb2D.velocity * maxSpeed;
            }
            else
            {
                collidedPill1 = false;
                timer = 0.0f;
            }
        }
        else if (collidedPill2)
        {
            timer = timer + Time.deltaTime;

            if (timer < 6)
            {
                rb2D.velocity = new Vector2((rb2D.velocity.x) / 2, (rb2D.velocity.y) / 2);
            }
            else
            {
                collidedPill2 = false;
                timer = 0.0f;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Debug.Log("OnCollisionEnter2D");

            collidedEnemy = true;
        }
        else if(col.gameObject.tag == "pill1")
        {
            collidedPill1 = true;
        }
        else if(col.gameObject.tag == "pill2")
        {
            collidedPill2 = true;
        }
        else if (col.gameObject.tag == "obj")
        {
            collidedObj = true;
        }

    }
}
