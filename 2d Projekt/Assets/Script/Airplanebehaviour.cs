using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplanebehaviour : MonoBehaviour
{
    public GameObject bomb;

    void Update()
    {

        // When spacebar is hit
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // instantiate the fireball object
            Instantiate(bomb,
                new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0),
                new Quaternion(0, 0, 0, 0));
        }
    }

}