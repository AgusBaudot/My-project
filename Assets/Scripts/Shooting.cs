using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    #region Bullets
    public GameObject bullet;
    Rigidbody body;
    #endregion

    private void Start()
    {
        //Encontrar objetos con tag bullet y asignarles el rigidbody para despues modificarles la velocidad.
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
        body.velocity = transform.
    }
}
