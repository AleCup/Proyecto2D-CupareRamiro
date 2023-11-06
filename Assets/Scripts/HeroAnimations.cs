using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAnimations : MonoBehaviour
{
    
    private Animator animator; //referencia al componente animator del personaje

    void Start()
    {
        animator = GetComponent<Animator>(); //obtenemos la referencia al componente Animator
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetBool("isRunning", true); //activa la animacion de caminar 
        }
        else
        {
            animator.SetBool("isRunning", false); //desactiva la animacion de caminar
        }
    }
    //cuando el personaje colisiona con un objeto, desactiva la animacion de salto
    public void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("isJumping", false); //desactiva la animacion de saltar
    }

    //cuando el personeje deja de colisionar con un objeto, activa la animacion de salto
    public void OnCollisionExit2D(Collision2D collision)
    {
        animator.SetBool("isJumping", true); //activa la animacion de saltar
    }
}
