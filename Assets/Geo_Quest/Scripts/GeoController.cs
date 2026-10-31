using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    // Start is called before the first frame update

    int var3 = 3;
    private Rigidbody2D rb;
    private bool isGrounded = true;
    public int speed = 7;
    public int jumpForce = 7;
    public int gravity = 7;
    public string nextLevel = "Level2";
    public Color color1 = Color.red;
    public Color color2 = Color.green;
    public Color color3 = Color.blue;
    private Renderer playerRenderer;
    private SpriteRenderer _spriteRenderer;
    void Start()
    {
        _spriteRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>();
        //playerRenderer = GetComponent<Renderer>();
        //Defualt Color
        //playerRenderer.material.color = color1;
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
            switch (Input.inputString)
            {
                case "1":
                    playerRenderer.material.color = color1;
                    break;
                case "2":
                    playerRenderer.material.color = color2;
                    break;
                case "3":
                    playerRenderer.material.color = color3;
                    break;
            }
        void SwitchColor(Color newColor)
        {
            playerRenderer.material.color = newColor;
        }
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
        }
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);

        if (xInput > 0) { _spriteRenderer.flipX = true; }
        else if (xInput < 0) { _spriteRenderer.flipX = false; }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
            {
                string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene (thisLevel);
                    break;
            }
                case "Finish":
            {
                SceneManager.LoadScene (nextLevel);
                break;
                }
        }
     Debug.Log ("Hit");
    }
}