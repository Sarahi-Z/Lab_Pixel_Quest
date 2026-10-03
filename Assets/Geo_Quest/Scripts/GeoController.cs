using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GeoController : MonoBehaviour
{
    // Start is called before the first frame update
    string Var2 = "Hello ";
    int var3 = 3;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Debug.Log(Var2 + "World");
        //Var2 = "Goodbye ";
        //Debug.Log(Var2 + "World");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input. GetKeyDown(KeyCode.A))
        { 
        rb.velocity = new Vector2(-1, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(1, rb.velocity.y);
        }
    } }
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