using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    // 1 get a reference and start an instance of our input actions 
    // 2. Engable input action Map (dog)
    //3 . Register perform functions
    private PlayerInputSystem _input;

    private void Start()
    {
        _input = new PlayerInputSystem();
        _input.Dog.Enable();
        _input.Dog.Move.performed += Move_performed;
        _input.Dog.Bark.performed += Bark_performed;
        _input.Dog.Run.performed += Run_performed;
        _input.Dog.Bark.canceled += Bark_canceled;
        _input.Dog.Die.performed += Die_performed;
    }

    private void Die_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Die performed..." + context);
    }

    private void Run_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Running Performed..." + context);
    }

    private void Move_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Walking performed..." + context);
    }

    private void Bark_canceled(InputAction.CallbackContext context)
    {
        Debug.Log("Barking cancelled" + context);
    }

    private void Bark_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Barking..." + context);
    }
}
