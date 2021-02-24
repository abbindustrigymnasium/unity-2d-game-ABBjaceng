using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplanebehaviour : MonoBehaviour
{

    public GameObject bomb;
    public int Mag = 3;
    public int Ammo;

    void Update()
    {

        // When spacebar is hit
        if (Input.GetKeyDown(KeyCode.Space) && Ammo > 0)
        {
            // instantiate the fireball object
            Debug.Log(Ammo);
            Instantiate(bomb,
                new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0),
                new Quaternion(0, 0, 0, 0));
            Ammo -= 1;
                
        }
        if (transform.position.x <= -10)
        {
            Ammo = Mag;
        }
    }
    

}