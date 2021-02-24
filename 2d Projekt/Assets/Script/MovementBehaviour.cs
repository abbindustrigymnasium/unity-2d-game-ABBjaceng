using UnityEngine;
using System.Collections;

public class MovementBehaviour : MonoBehaviour
{
    public float speed;
    public GameObject hitEffect;
    public int yReset = 1;
    public int xReset = 22;

    GameObject[] finishObjects;

    // Use this for initialization
    void Start()
    {
        finishObjects = GameObject.FindGameObjectsWithTag("ShowOnFinish");          //gets all objects with tag ShowOnFinish
        Debug.Log(finishObjects);
        hideFinished();
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);

        if (transform.position.x <= -11)
        {
            transform.position = new Vector2(transform.position.x + xReset, transform.position.y - yReset);

        }
        if (transform.position.y < -3.1)
        {
            Application.LoadLevel("MainFinish");
        }   
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "House")
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);
            Destroy(gameObject);
            showFinished();
        }
    }

    //shows objects with ShowOnFinish tag
    public void showFinished()
    {
        foreach (GameObject g in finishObjects)
        {
            Debug.Log("gameover");
            Debug.Log(g);
            g.SetActive(true);
        }
    }

    //hides objects with ShowOnFinish tag
    public void hideFinished()
    {
        foreach (GameObject g in finishObjects)
        {
            g.SetActive(false);
        }
    }
}