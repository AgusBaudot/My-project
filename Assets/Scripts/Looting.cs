using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Looting : MonoBehaviour
{
    public int counter = 20;
    public bool CanShoot = true;
    public TextMeshProUGUI ammoCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter > 0)
        {
            CanShoot = true;
        }
        if (counter == 0)
        {
            CanShoot = false;
        }
        ammoCounter.text = counter + " bullets left.";
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ammo")
        {
            counter++;
            Destroy(col.gameObject);
        }
    }
}
