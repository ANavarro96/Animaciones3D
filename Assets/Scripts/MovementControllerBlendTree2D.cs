using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class MovementControllerBlendTree2D : MonoBehaviour
{
    public float speed = 5.0f; // La velocidad a la que se va a mover el personaje



    private CharacterController characterController;
    private Animator animatorController;

    void Start()
    {
        // Get the Character Controller on the player
        characterController = GetComponent<CharacterController>();
        animatorController = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");


        // Calculamos el vector de movimiento -> ((0,0,1) * vertical + (1,0,0) * horizontal) * speed
        Vector3 move = transform.forward * vertical + transform.right * horizontal;
        characterController.Move(move * speed * Time.deltaTime);

        // TODO: Establecer las animaciones!
        
  

    }
   }
