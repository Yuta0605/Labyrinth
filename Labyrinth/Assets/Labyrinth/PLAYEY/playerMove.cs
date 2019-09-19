using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMove : MonoBehaviour
{
    public float playerSpeed = 3.0f;//速度

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerVelocity();
    }
    

    //プレイヤーの移動
    void playerVelocity()
    {
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * playerSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("down"))
        {
            transform.position -= transform.forward * playerSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("right"))
        {
            transform.position += transform.right * playerSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("left"))
        {
            transform.position -= transform.right * playerSpeed * Time.deltaTime;
        }
    }
}
