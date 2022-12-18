using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storyBoarding : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        if (PlayerPrefs.HasKey("game"))
        {
            if (PlayerPrefs.GetInt("level") == 1)
            {
                anim.SetInteger("level", 1);
            }
            else if (PlayerPrefs.GetInt("level") == 2)
            {
                anim.SetInteger("level", 2);
            }
            else if (PlayerPrefs.GetInt("level") == 3)
            {
                anim.SetInteger("level", 3);
            }
            else if (PlayerPrefs.GetInt("level") == 4)
            {
                anim.SetInteger("level", 4);
            }
            else
            {
                anim.SetInteger("level", 5);
            }
        }
        else
        {
            PlayerPrefs.SetInt("game", 1);
            anim.SetInteger("level", 1);
        }
    }
}
