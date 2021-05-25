using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] obstacle;

    public float tymbtwspawn;
    public float startTimespawn;
    public float decreasetym;
    public float mintym = 0.65f;

    private void Update()
    {
        if(tymbtwspawn <= 0)
        {
            int rand = Random.Range(0, obstacle.Length);
            Instantiate(obstacle[rand], transform.position, Quaternion.identity);
            tymbtwspawn = startTimespawn;
            if (startTimespawn > mintym)
            {
                startTimespawn -= decreasetym;
            }

        }
        else
        {
            tymbtwspawn -= 1 * Time.deltaTime;
        }
    }
}
