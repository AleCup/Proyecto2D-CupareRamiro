using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 250f; //velocidad del jugador
    private bool isFacingRight = true; // representa el valor de mirar a la derecha
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // se obtiene la referencia al rigidbody del personaje
    }

    // Update is called once per frame
    void Update()
    {
        float movementX = Input.GetAxis("Horizontal"); //se obtiene la entrada de movimiento horizontal (-1 a 1)
        MovePlayer(movementX * movementSpeed);

        if (movementX < 0 && isFacingRight)
        {
            FlipPlayer();
        }
        else if (movementX > 0 && !isFacingRight)
        {
            FlipPlayer();        
        }
    }

    public void MovePlayer(float velocity)
    {
        rb.velocity = new Vector2(velocity * Time.deltaTime, rb.velocity.y);
    }
    public void FlipPlayer()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        isFacingRight = !isFacingRight;
    }
}
