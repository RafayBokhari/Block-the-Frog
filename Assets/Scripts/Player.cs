using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float padding = 0.8f;
    private float  minX;
    private float maxX;
    private float minY;
    private float maxY;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        FindBoundaries();
    }

    void FindBoundaries()
    {
        Camera gameCamera = Camera.main;
       
        minX = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        maxX = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;
        minY = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        maxY = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;
    }

    // Update is called once per frame
    void Update()
    {
        float newXpos = Mathf.Clamp(transform.position.x, minX, maxX);
        float newYpos = Mathf.Clamp(transform.position.y, minY, maxY);

        transform.position = new Vector2(newXpos, newYpos);


        if (Input.GetMouseButton(0))
        {
            Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (newPos.x < 0)
            {
                rb.AddForce(Vector2.left * moveSpeed);
            }
            else
            {
                rb.AddForce(Vector2.right * moveSpeed);
            }
        }
        else
        {
            rb.velocity = Vector2.zero;

        }
       

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Block")
        {
            SceneManager.LoadScene(0);
        }
    }

}
