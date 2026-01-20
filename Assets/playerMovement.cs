using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce; // jump loncat
    float score;

    public Text scoretxt; // teks score

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // perkenalkan inisialisasi
    }

    // Update is called once per frame
    void Update()
    {
        scoretxt.text = "Score: " + score;

        if (Input.GetMouseButtonDown(0)) // klik mouse kiri untuk PC / tap untuk HP
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "point")
        {
            score++;
        }
        if(collision.gameObject.tag =="pipa")
        {
            Destroy(gameObject);
        }

    }
}