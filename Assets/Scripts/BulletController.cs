using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource source;
    float bulletTtl = 2;
    public GameObject ScoreManager;
    public ScoreScript MyScoreScript;
    public GameObject Speler1;
    public GameObject Speler2;
    // Start is called before the first frame update
    void Start()
    {
        ScoreManager = GameObject.Find("Canvas");
        MyScoreScript = ScoreManager.GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    public void Update()
    {
        bulletTtl -= Time.deltaTime;
        if (bulletTtl <= -10f)
        {
            GameObject.Find("GameManager").GetComponent<TurnEngine>().wisselBeurt();
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(clip, Vector3.zero);
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("player geraakt");
            if(collision.gameObject.GetComponent<TankController>().spelerNummer == 1)
            {
                GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP2Score();
            }
         
        }
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("playertje geraakt");
            if (collision.gameObject.GetComponent<TankController>().spelerNummer == 2)
            {
                GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP1Score();
            }

        }
        if (collision.gameObject ==Speler2)
        {
            MyScoreScript.AddP2Score();
        }
        GameObject.Find("GameManager").GetComponent<TurnEngine>().wisselBeurt();
        Destroy(gameObject);

       
    }
}
