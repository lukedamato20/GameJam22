using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objController : MonoBehaviour
{
    public Rigidbody2D obj;
    float objX, objY;
    public int level = 1;
    public playerMovement playerMvmt;

    void Start()
    {
        if (PlayerPrefs.HasKey("level"))
        {
            level = PlayerPrefs.GetInt("level");
        }
        else
        {
            level = 0;
        }

        if (PlayerPrefs.GetInt("level") == 1)
        {
            objX = Random.Range(-7.5f, 7.5f);
            objY = Random.Range(-7.5f, 7.5f);
        }
        else if (PlayerPrefs.GetInt("level") == 2)
        {
            objX = Random.Range(-9.5f, 9.5f);
            objY = Random.Range(-9.5f, 9.5f);

            obj.transform.position = new Vector2(objX, objY);

        }
        else if (PlayerPrefs.GetInt("level") == 3)
        {
            objX = Random.Range(-11.5f, 11.5f);
            objY = Random.Range(-11.5f, 11.5f);

            obj.transform.position = new Vector2(objX, objY);

        }
        else if (PlayerPrefs.GetInt("level") == 4)
        {
            objX = Random.Range(-15.5f, 15.5f);
            objY = Random.Range(-15.5f, 15.5f);

            obj.transform.position = new Vector2(objX, objY);
        }
    }
}
