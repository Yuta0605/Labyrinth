using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerState : MonoBehaviour
{
    public bool playerLightingFlag; //明るさ判定

    // Start is called before the first frame update
    void Start()
    {
        playerLightingFlag = true; // 明るい
    }

    // Update is called once per frame
    void Update()
    {
        isLight();
    }

    //「ｚ」を押したら判定を逆転する
    void isLight()
    {
        if (Input.GetKeyDown("z"))
        {
            playerLightingFlag = !playerLightingFlag;
            Debug.Log("aaa");
        }
    }

    public bool getLighting()
    {
        return playerLightingFlag;
    }
}
