using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHorizontally2 : MonoBehaviour
{
    public static float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            transform.Translate(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, 0));
        }
    }
    public void speedChanger()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed = 0;
            MoveHorizontally.Speed = 20;
        }
    }
}
