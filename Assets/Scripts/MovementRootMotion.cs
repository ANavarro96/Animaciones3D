using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRootMotion : MonoBehaviour
{

    private Animator animatorController;

    void Start()
    {
      
        animatorController = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        // TODO: Establecer animaciones

    }

}
