using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ligthActive : MonoBehaviour
{
    GameObject flash;
    Light light;

    GameObject player;
    playerState pState;

    bool isLightFlag;

    // Start is called before the first frame update
    void Start()
    {
        flash = GameObject.FindGameObjectWithTag("light");
        light = flash.GetComponent<Light>();

        player = GameObject.FindGameObjectWithTag("Player");
        pState = player.GetComponent<playerState>();

        isLightFlag = true;
    }

    // Update is called once per frame
    void Update()
    {
        lightorDark();

    }

    //プレイヤーの判定でライト反転
    void lightorDark()
    {
        if (!pState.getLighting())
        {
            //flash.SetActive(false);
            isLightFlag = false;
            light.enabled = false;
        }
        else
        {
            //flash.SetActive(true);
            isLightFlag = true;
            light.enabled = true;
        }
    }

    public bool getLightFlag()
    {
        return isLightFlag;
    }
}
