using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerInputActions _input;
    private Rigidbody _body;
    [SerializeField] float _jump;
    // Start is called before the first frame update
    void Start()
    {
       
        _input = new PlayerInputActions();
        _input.Player.Enable();
        _input.Player.Jumping.performed += Jumping_performed;
        _input.Player.MidJump.performed += MidJump_performed;
        _input.Player.HighJumping.performed += HighJumping_performed;
        _body = GetComponent<Rigidbody>();
    }

    private void HighJumping_performed(InputAction.CallbackContext obj)
    {
        _body.AddForce(Vector2.up * _jump * 2, ForceMode.Impulse);
    }


    private void MidJump_performed(InputAction.CallbackContext obj)
    {
        _body.AddForce(Vector2.up * _jump *1.5f, ForceMode.Impulse);
    }

    private void Jumping_performed(InputAction.CallbackContext obj)
    {
        _body.AddForce(Vector2.up * _jump, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("Jumping");
        }

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("Mouse pressed");
        }
    }
}
