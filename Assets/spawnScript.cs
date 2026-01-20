using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    float time = 0;
    float timer = 1;
    public GameObject pipes;

    // Update is called once per frame
    void Update()
    {
        if (time <= 0)
        {
            Instantiate(pipes, transform.position, Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}