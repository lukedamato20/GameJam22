using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    // user vars
    float moveSpeeda = 0.5f;
    public float moveSpeed = 5;
    public Rigidbody2D rb;
    public Vector2 moveDirection;
    
    // obj vars
    public bool objTaken = false;
    
    // level vars
    public int level = 1;

    void Start()
    {
        // setting user position in the middle of the maze
        if (!PlayerPrefs.HasKey("game_scene"))
        {
            PlayerPrefs.SetString("game_scene", "scene");
            PlayerPrefs.SetInt("level", 1);
        }

        rb.transform.position = new Vector2(0, 0);
        Debug.Log(level);
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // When target is hit
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("Collision detected");  

            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "pill1")
        {
            // pill 1 -- user speed * 2
            Debug.Log("Collision pill1");

            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "pill2")
        {
            // pill 2 -- user speed / 2
            Debug.Log("Collision pill2");

            Destroy(col.gameObject);
        }
        
        if (col.gameObject.tag == "door")
        {
            if (PlayerPrefs.GetInt("level") == 1)
            {
                SceneManager.LoadScene("Maze1");
            }
            else if (PlayerPrefs.GetInt("level") == 2)
            {
                SceneManager.LoadScene("Maze2");
            }
            else if (PlayerPrefs.GetInt("level") == 3)
            {
                SceneManager.LoadScene("Maze3");
            }
            else if (PlayerPrefs.GetInt("level") == 4)
            {
                SceneManager.LoadScene("Maze4");
            }
            else
            {
                //end of game
                PlayerPrefs.SetInt("level", 1);
                SceneManager.LoadScene("Credits");
            }

        }
        
        if (col.gameObject.tag == "obj")
        {
            objTaken = true;

            // Object Collected
            Debug.Log("Collision obj, Level:");

            level = PlayerPrefs.GetInt("level");
            level += 1;
            
            PlayerPrefs.SetInt("level", level);
            Debug.Log("Level: " + level);
            
            SceneManager.LoadScene("Hub");
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(new Vector2(moveDirection.x, moveDirection.y) * moveSpeeda, ForceMode2D.Impulse);
    }

    void ProcessInput()
    { 
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }
}
