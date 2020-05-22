using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kyara : MonoBehaviour
{

    //public Vector3 SPEED = new Vector3(0.01f, 0.01f,0.0f);
    public float jump = 350;
    bool isflg = false;

    private Rigidbody rb;

    public float SpeedX;
    // xbox
    public float moveHorizontal;
    public float moveVertical;

    // Use this for initialization
    void Start()
    {
        //float x = Input.GetAxis("Horizontal");
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        Vector3 raystart = transform.position;
        raystart.y += 0.5f;
        //　Cubeのレイを飛ばしターゲットと接触しているか判定
        if (Physics.BoxCast(raystart, Vector3.one * 0.5f, Vector3.down, out hit, Quaternion.identity, 0.5f, LayerMask.GetMask("Default")))
        {
            isflg = false;
        }

        if (!isflg) // 地面フラグ
        {
            if (Input.GetKey("space"))
            {
                rb.AddForce(Vector2.up * jump);
                isflg = true;
            }
        }

        Move(); // 横移動
    }

    // 横移動
    void Move()
    {
        Vector3 Position = transform.position;

        if (Input.GetKey("left"))
        {
            transform.position -= new Vector3(SpeedX, 0.0f, 0.0f);
        }
        else if (Input.GetKey("right"))
        {
            transform.position += new Vector3(SpeedX, 0.0f, 0.0f);
        }

    }

}
