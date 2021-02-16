using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bombbehaviour : MonoBehaviour
{
    private float fireballXValue;
    public float fireballSpeed;
    public float Speed;

    void Start()
    {
        // getting the initial position where prefab is created
        fireballXValue = gameObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        // adding speed value to the X axis position
        // value
        //fireballXValue += fireballSpeed;
        // setting new X value to position
        //gameObject.transform.position = new Vector2(fireballXValue, gameObject.transform.position.y);
        transform.Translate(Vector2.left * Time.deltaTime * Speed);
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Target was Hit!" + col.gameObject.tag + this.gameObject.tag);
        // When target is hit
        if (col.gameObject.tag == "House")
        {
            Debug.Log("Target was Hit!");
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }
}