using UnityEngine;
using System.Collections;

public class MovementBehaviour : MonoBehaviour
{
    public float speed;
    public int yReset = 1;
    public int xReset = 22;

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);

        if (transform.position.x <= -11)
        {
            transform.position = new Vector2(transform.position.x + xReset, transform.position.y - yReset);


        }
    }
}