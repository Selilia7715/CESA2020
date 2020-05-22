using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respone : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //Application.targetFrameRate = 60;   //60fps
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    //リスポーン
    void Respone()
    {
        //transform.Translate(-7.0f, 2.0f, 0.0f);     //リスポーン座標
        Transform myTransform = player.transform;         //オブジェクトの位置取得
        Vector3 pos = myTransform.position;
        pos.x = 1.0f;
        pos.y = 1.002f;
        pos.z = 0.01f;
        myTransform.position = pos;

        /* (-4.0f, 2.0f, 0.0f);     //リスポーン座標*/
        player.SetActive(true);         //自機を見えるようにする
    }

    //当たり判定
    void OnCollisionEnter(Collision collision)
    {
        //敵に当たったら
        if (collision.gameObject.tag == "Player")
        {
            //Responeを3秒後に呼び出す
            Invoke("Respone", 2.5f);
            player.SetActive(false);            //自機を見えないようにする
        }
    }
}
