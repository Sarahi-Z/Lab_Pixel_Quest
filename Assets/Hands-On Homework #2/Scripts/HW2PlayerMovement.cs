using UnityEngine;

public class HW2PlayerMovement : MonoBehaviour
{
private Rigidbody2D _Rigidbody2D;

private float _xSpeed;
private float _ySpeed;

public float Speed = 3;

private string InputX = "Horizontal";
private string InputY = "Vertical";
private void Start()
{
    _Rigidbody2D = GetComponent<Rigidbody2D>();
}

private void Update()
{
    _xSpeed = Input.GetAxis(InputX);
    _ySpeed = Input.GetAxis(InputY);
    _Rigidbody2D.velocity = new Vector2(_xSpeed, _ySpeed) * Speed;
}

}