using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    Rigidbody body;
    public float velocidadDisparo = 10f;

    private void Start()
    {
        body = gameObject.GetComponent<Rigidbody>();
        //body.velocity = transform.TransformDirection(Vector3.forward * velocidadDisparo);
    }
    private void Update()
    {
    }
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
