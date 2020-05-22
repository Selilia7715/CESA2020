using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public int TimeCnt = 0;
    public float SpeedY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeCnt++;

        Vector3 position = transform.position;


        if (TimeCnt >= 1380)
        {
            transform.position += new Vector3(0.0f, SpeedY, 0.0f);
        }

    }
}
