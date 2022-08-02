using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    #region Bullets
    public GameObject bullet;
    Rigidbody body;
    public float fuerzaDisparo = 0.1f;
    public float velocidadDisparo = 10f;
    float TotalCD = 0.3f;
    float CurrentCD;
    #endregion

    private void Start()
    {
        //Encontrar objetos con tag bullet y asignarles el rigidbody para despues modificarles la velocidad.
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && CurrentCD <= 0)
        {
            GameObject clon;
            clon = Instantiate(bullet, transform.position, Quaternion.identity);
            body = clon.GetComponent<Rigidbody>();
            body.AddForce(clon.transform.up * fuerzaDisparo, ForceMode.Impulse);
            Destroy(clon, 3);
            CurrentCD = TotalCD;
        }
        body.velocity = transform.TransformDirection(Vector3.forward * velocidadDisparo);
        CurrentCD -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Mouse0) && CurrentCD > 0)
        {
            Debug.Log("CD is still active, can't shoot");
        }
    }

}
