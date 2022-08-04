using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyactivation : MonoBehaviour
{
    #region Spawns
    public Transform[] SpawnPoint;
    #endregion

    #region Enemy
    public GameObject Enemy;
    public GameObject[] EnemyManager;
    #endregion

    #region EnemyActivation
    public string Spawn;
    public string Movement;
    #endregion

    #region HasActivated
    bool HasActivatedSpawn = false;
    bool HasActivatedMovement = false;
    #endregion

    #region Walls
    public GameObject SpawnWall;
    public GameObject MovementWall;
    #endregion

    void Update()
    {
        if (HasActivatedSpawn)
        {
            SpawnWall.SetActive(false);
        }
        if (HasActivatedMovement)
        {
            MovementWall.SetActive(false);
        }
    }
    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.tag == Spawn && !HasActivatedSpawn)
        {
            HasActivatedSpawn = true;
            for (int i = 0; i <= 3; i++)
            {
                Instantiate(Enemy, SpawnPoint[i].transform.position, SpawnPoint[i].transform.rotation);
            }
            Debug.Log("Activo el spawn");
        }
        if (col.gameObject.tag == Movement && !HasActivatedMovement)
        {
            HasActivatedMovement = true;
            EnemyManager = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemies in EnemyManager)
            {
                enemies.transform.Translate(1, 0, 0);
            }
            Debug.Log("Activo el movimiento");
        }
    }
}