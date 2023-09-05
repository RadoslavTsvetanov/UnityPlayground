using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb2D;
    [SerializeField] private float speed = 2;
    public float jump = 500;
    private float Move;
    private bool CanJump;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb2D.velocity = new Vector2(speed * Move,rb2D.velocity.y);

        if (Input.GetButtonDown("Jump") && CanJump)
        {
            rb2D.AddForce(new Vector2(rb2D.velocity.x, jump));
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            CanJump = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            CanJump = false;
        }
    }
}
