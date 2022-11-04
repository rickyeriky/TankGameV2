using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    [SerializeField]
    Transform barrelRotator;
    [SerializeField]
    Transform firePoint;
    [SerializeField]
    GameObject bulletoFire;
    public int spelerNummer;
    bool aanDeBeurt = false;
    public float ShotPower = 4f;
    public static float Speed;
    public GameObject cow;
    public bool AlreadyShot = false;
    // Start is called before the first frame update
    void Start()
    {
        Speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (aanDeBeurt == true)
        {


            barrelRotator.RotateAround(Vector3.forward, Input.GetAxis("Vertical") * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.Space) && AlreadyShot == false)
            {
                GameObject b = Instantiate(bulletoFire, firePoint.position, firePoint.rotation);
                b.GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * ShotPower, ForceMode2D.Impulse);
                AlreadyShot = true;
                
            }
            {
                transform.Translate(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * Speed, 0, 0));
            }
            if(Input.GetKeyDown(KeyCode.LeftShift))
            {
                ShotPower++;
            }
            if(Input.GetKeyDown (KeyCode.LeftControl))
            {
                ShotPower--;
            }



            if (Input.GetKey(KeyCode.C))
            {
                cow.SetActive(true);
            }
            else
            {
                cow.SetActive(false);
            }

        }
    }
    public void zetBeurt(bool b)
    {
        if (b == true)
        {
            Invoke("SetTrue", 0.2f);
        }
        else
        {
            aanDeBeurt = false;
        }
    }

    void SetTrue()
    {
        aanDeBeurt = true;
        AlreadyShot = false;
    }
}