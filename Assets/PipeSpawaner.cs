using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawaner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipePrefab;
    public float height;
    void Update()
    {
        if(timer >maxTime)
        {
            GameObject newPipe =  Instantiate(pipePrefab);
            newPipe.transform.position = transform.position + new Vector3(0,Random.Range(height,-height),0);
            Destroy(newPipe, 15);

            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
