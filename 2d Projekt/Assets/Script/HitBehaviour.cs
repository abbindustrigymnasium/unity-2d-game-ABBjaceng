using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBehaviour : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Tar Hit!");
    }


    void Update()
    {
        Debug.Log("Tar Hit2222!");
    }


    void onTriggerEnter2D(Collider2D col)
    {Debug.Log("Target was Hit!" + col.gameObject.tag + this.gameObject.tag);
        // When target is hit
        if (col.gameObject.tag == "Bomb")
        {
            Debug.Log("Target was Hit!");

            
        }

    }

}