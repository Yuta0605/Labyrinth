using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReversingDoor : MonoBehaviour
{
    BoxCollider coll;
    public GameObject lightObject;//ライト用オブジェクト
    public lightActive Light;//ライト判定用
    bool pastLight;

    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<BoxCollider>();
        Light = lightObject.GetComponent<lightActive>();//ライトを取得
    }

    // Update is called once per frame
    void Update()
    {
        //ライトの有無によってあたり判定の変更
        if (pastLight != Light.getLightFlag())
        {
            Inversion();
        }
        pastLight = Light.getLightFlag();
    }

    //当たり判定の反転
    void Inversion()
    {
        coll.enabled = !coll.enabled;
    }
}
