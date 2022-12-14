using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    #region Bullets
    public GameObject bullet;
    Rigidbody body;
    public float fuerzaDisparo = 60f;
    float TotalCD = 0.3f;
    float CurrentCD;
    GameObject clon;
    #endregion

    public Looting looting;

    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && CurrentCD <= 0 && looting.CanShoot)
        {
            clon = Instantiate(bullet, transform.position, transform.rotation);
            body = clon.GetComponent<Rigidbody>();
            body.AddForce(clon.transform.forward * fuerzaDisparo, ForceMode.Impulse);
            Destroy(clon, 3);
            CurrentCD = TotalCD;
            looting.counter--;
        }
        CurrentCD -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Mouse0) && CurrentCD > 0)
        {
            Debug.Log("CD is still active, can't shoot");
        }
        if (!looting.CanShoot)
        {
            Debug.Log("Don't have enough bullets");
        }
        
    }

}
