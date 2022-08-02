using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    #region Loot
    public GameObject loot;
    #endregion

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Debug.Log("Se hizo contacto");
            for (int i = 0; i <= 3; i++)
            {
                Instantiate(loot, transform.position, transform.rotation);
            }
            Destroy(gameObject);
        }
    }
}
