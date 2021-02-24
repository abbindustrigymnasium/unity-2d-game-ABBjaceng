using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bombbehaviour : MonoBehaviour
{ 
    public float Speed;
    public GameObject hitEffect;

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
        // When target is hit
        if (col.gameObject.tag == "House")
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Ground")
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);
            Destroy(gameObject);
        }
    }
}