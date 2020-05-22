using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public int TimeCnt = 0; // タイムカウント
    public float Speed = -0.0036f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 17.5f);
    }

    // Update is called once per frame
    void Update()
    {
        TimeCnt++;

        if(TimeCnt > 300)
        {
            Vector3 localScale = transform.localScale;

            bool isflg = true;

            if (transform.localScale.x >= 0.0f)
            {
                isflg = true;
            }
            else
            {
                isflg = false;
            }

            if (isflg == true)
            {
                transform.localScale += new Vector3(Speed, 0.0f, 0.0f);
            }
            else
            {
                transform.localScale += new Vector3(0.0f, 0.0f, 0.0f);

            }
        }
    }
}
