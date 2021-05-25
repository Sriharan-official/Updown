using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public Animator camanim;

    public void CamShake()
    {
        int rand = Random.Range(0, 3);
        if (rand == 0)
        {
            camanim.SetTrigger("shake");
        }
        else if(rand == 1)
        {
            camanim.SetTrigger("shake1");
        } 
        else if(rand == 2)
        {
            camanim.SetTrigger("shake2");
        }
    }
}
