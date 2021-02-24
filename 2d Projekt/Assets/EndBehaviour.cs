using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBehaviour : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(2.5);
    }
    
}
