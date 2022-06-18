// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""67e2e0aa-9271-4623-9ef3-bca2987cde6e"",
            ""actions"": [
                {
                    ""name"": ""Jumping"",
                    ""type"": ""Button"",
                    ""id"": ""2bcb9e42-30d9-4cb5-91c2-cc23788f0bed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HighJumping"",
                    ""type"": ""Button"",
                    ""id"": ""80b303a9-4aaa-4f4b-969d-deb6df794e49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MidJump"",
                    ""type"": ""Button"",
                    ""id"": ""85bffd9c-c7c6-42d7-b09f-24a9a5a9efe9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3b694083-0d4e-4f67-870a-23cdf4d1d083"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jumping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2785008a-fa83-4a61-b6be-f43b02932f78"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold(duration=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HighJumping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3027a396-a85c-4dfc-8e8c-a4d5a3a97077"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold(duration=0.5)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MidJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Jumping = m_Player.FindAction("Jumping", throwIfNotFound: true);
        m_Player_HighJumping = m_Player.FindAction("HighJumping", throwIfNotFound: true);
        m_Player_MidJump = m_Player.FindAction("MidJump", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Jumping;
    private readonly InputAction m_Player_HighJumping;
    private readonly InputAction m_Player_MidJump;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jumping => m_Wrapper.m_Player_Jumping;
        public InputAction @HighJumping => m_Wrapper.m_Player_HighJumping;
        public InputAction @MidJump => m_Wrapper.m_Player_MidJump;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Jumping.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumping;
                @Jumping.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumping;
                @Jumping.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJumping;
                @HighJumping.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHighJumping;
                @HighJumping.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHighJumping;
                @HighJumping.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHighJumping;
                @MidJump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMidJump;
                @MidJump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMidJump;
                @MidJump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMidJump;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jumping.started += instance.OnJumping;
                @Jumping.performed += instance.OnJumping;
                @Jumping.canceled += instance.OnJumping;
                @HighJumping.started += instance.OnHighJumping;
                @HighJumping.performed += instance.OnHighJumping;
                @HighJumping.canceled += instance.OnHighJumping;
                @MidJump.started += instance.OnMidJump;
                @MidJump.performed += instance.OnMidJump;
                @MidJump.canceled += instance.OnMidJump;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnJumping(InputAction.CallbackContext context);
        void OnHighJumping(InputAction.CallbackContext context);
        void OnMidJump(InputAction.CallbackContext context);
    }
}
