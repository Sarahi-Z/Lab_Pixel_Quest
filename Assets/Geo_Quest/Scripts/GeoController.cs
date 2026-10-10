using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    // Start is called before the first frame update
    string Var2 = "Hello ";
    int var3 = 3;
    private Rigidbody2D rb;
    public int speed = 7;
    public string nextLevel = "Level2";
    public Color color1 = Color.red;
    public Color color2 = Color.green;
    public Color color3 = Color.blue;
    private Renderer playerRenderer;
    void Start()
    {
        playerRenderer = GetComponent<Renderer>();
        //Defualt Color
        playerRenderer.material.color = color1;
        rb = GetComponent<Rigidbody2D>();
        //Debug.Log(Var2 + "World");
        //Var2 = "Goodbye ";
        //Debug.Log(Var2 + "World");
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
        float xInput = Input.GetAxis("Horizontal");
       rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
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
        //Debug.Log(var3);
        //var3++;
/*
if (Input.GetKeyDown(KeyCode.W))
{
    transform.position += new Vector3(0, 1, 0);
}
if (Input.GetKeyDown(KeyCode.S))
{
    transform.position += new Vector3(0, -1, 0);
}
if (Input.GetKeyDown(KeyCode.D))
{
    transform.position += new Vector3(1, 0, 0);
}
if (Input.GetKeyDown(KeyCode.A))
{
    transform.position += new Vector3(-1, 0, 0);
}
*/