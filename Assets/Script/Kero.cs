using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kero : MonoBehaviour
{


    Rigidbody2D rb;
    float dirX;
    float moveSpeed = 10f;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Food")
        {
       
            Destroy(collision.gameObject);
        }

        if(collision.tag == "Vegetable")
        {
           
            Destroy(collision.gameObject);
            SceneManager.LoadScene(2);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.acceleration.x * moveSpeed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, 0f);
    }
}
