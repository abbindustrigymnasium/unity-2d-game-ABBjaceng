using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public float thrust = 2.0f;
    public Rigidbody2D rb;
    public GameObject move;
    public Vector3 offset;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(2.0f);

        rb = GetComponent<Rigidbody2D>();
        offset = transform.position - move.transform.position;
        rb.AddForce(-transform.right * thrust);
    }

    /*void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        offset = transform.position - move.transform.position;
        rb.AddForce(-transform.right * thrust);
    }*/

    //movementcode
    void Update()
    {       
        if (rb.velocity.x != 0)
        {
            rb.velocity -= rb.velocity * 0.9f * Time.deltaTime;      //Edit 0.95 with the value you want as long as it is smaller than 1 and bigger than 0
        }
    }

    void LateUpdate()
    {
        transform.position = move.transform.position + offset;
    }
}
