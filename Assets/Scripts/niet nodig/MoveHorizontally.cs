using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontally : MonoBehaviour
{
    public static float Speed;
    public GameObject cow;

    void Start()
    {
        Speed = 10f;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            cow.SetActive(true);
        }
        else
        {
            cow.SetActive(false);
        }
        {
            transform.Translate(new Vector3( Input.GetAxis("Horizontal") * Time.deltaTime * Speed,0, 0));
        }
        if (moveHorizontally2.speed == 0)
        {
            Speed = 10;
        }
        else
        {
            Speed = 0;
        }
    }
    public void speedChanger()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Speed = 0;
            moveHorizontally2.speed = 10;
        }
    }
}
