using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe2 : MonoBehaviour
{
    public int TimeCnt = 0;
    public float SpeedX = -0.0021f;
    public float SpeedY = -0.0024f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,4.8f);

    }

    // Update is called once per frame
    void Update()
    {
        TimeCnt++;

        Vector3 localScale = transform.localScale;

        bool isflg_x = true;
        bool isflg_y = true;

        if (transform.localScale.x >= 0.0f)
        {
            isflg_x = true;
        }
        else
        {
            isflg_x = false;
        }

        if (transform.localScale.y >= 0.0f)
        {
            isflg_y = true;
        }
        else
        {
            isflg_y = false;
        }


        if (TimeCnt <= 240)
        {
            if (isflg_x == true)
            {

                transform.localScale += new Vector3(SpeedX, 0.0f,0.0f);
            }
            else
            {
                transform.localScale += new Vector3(0.0f, 0.0f, 0.0f);

            }

        }
        else if(TimeCnt > 240)
        {
            if (isflg_y == true)
            {

                transform.localScale += new Vector3(0.0f, SpeedY, 0.0f);
            }
        }
        else if(TimeCnt >= 390)
        {
            transform.localScale += new Vector3(0.0f, 0.0f, 0.0f);

        }
    }
}
