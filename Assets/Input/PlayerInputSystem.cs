// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputSystem"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""4aac3f64-9881-4d4d-a2e2-410c8b0dbf3e"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""96551a42-67b9-485f-9020-4cad07e150bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""49d4e290-99e7-4a24-8c9d-250192a9471a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Dog"",
            ""id"": ""ad451f1e-e215-428a-b2cd-89a93fa23639"",
            ""actions"": [
                {
                    ""name"": ""Bark"",
                    ""type"": ""Button"",
                    ""id"": ""c1b9ac39-0f42-4f6f-8274-ffee2125ea3a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""bf3d0c7a-c318-411c-a98b-d17143775508"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Die"",
                    ""type"": ""Button"",
                    ""id"": ""32f43eac-ac92-4828-9525-3c83fce57d51"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""3fa5bf55-b0a6-4b82-bdb7-6221756fbcd6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""36c388c0-d89c-40d6-a7a5-c25262c938fe"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bark"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c272a542-88a2-4f59-aa07-9718cfef8cfd"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Hold(duration=1.1,pressPoint=0.5)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c9acb467-b4e6-49f3-ab9a-465a2c95b38b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7692f580-22a5-4471-a6e1-8292a564def2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b9a39011-806c-4d8e-a072-353b74ece554"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3dacdd71-fb41-4e88-b7a0-ef02889a7776"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1a620600-a2f8-4c24-a84b-150e5a401602"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Die"",
                    ""id"": ""f02ba206-d0c6-416a-a990-eaa3f219e41a"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Die"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""9caacbd1-449c-43d7-896b-12ea9aab6098"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Die"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""405bbdde-1b13-487f-bf73-a9909052e3be"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Die"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        // Dog
        m_Dog = asset.FindActionMap("Dog", throwIfNotFound: true);
        m_Dog_Bark = m_Dog.FindAction("Bark", throwIfNotFound: true);
        m_Dog_Run = m_Dog.FindAction("Run", throwIfNotFound: true);
        m_Dog_Die = m_Dog.FindAction("Die", throwIfNotFound: true);
        m_Dog_Move = m_Dog.FindAction("Move", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Fire;
    public struct PlayerActions
    {
        private @PlayerInputSystem m_Wrapper;
        public PlayerActions(@PlayerInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Dog
    private readonly InputActionMap m_Dog;
    private IDogActions m_DogActionsCallbackInterface;
    private readonly InputAction m_Dog_Bark;
    private readonly InputAction m_Dog_Run;
    private readonly InputAction m_Dog_Die;
    private readonly InputAction m_Dog_Move;
    public struct DogActions
    {
        private @PlayerInputSystem m_Wrapper;
        public DogActions(@PlayerInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Bark => m_Wrapper.m_Dog_Bark;
        public InputAction @Run => m_Wrapper.m_Dog_Run;
        public InputAction @Die => m_Wrapper.m_Dog_Die;
        public InputAction @Move => m_Wrapper.m_Dog_Move;
        public InputActionMap Get() { return m_Wrapper.m_Dog; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DogActions set) { return set.Get(); }
        public void SetCallbacks(IDogActions instance)
        {
            if (m_Wrapper.m_DogActionsCallbackInterface != null)
            {
                @Bark.started -= m_Wrapper.m_DogActionsCallbackInterface.OnBark;
                @Bark.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnBark;
                @Bark.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnBark;
                @Run.started -= m_Wrapper.m_DogActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnRun;
                @Die.started -= m_Wrapper.m_DogActionsCallbackInterface.OnDie;
                @Die.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnDie;
                @Die.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnDie;
                @Move.started -= m_Wrapper.m_DogActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_DogActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Bark.started += instance.OnBark;
                @Bark.performed += instance.OnBark;
                @Bark.canceled += instance.OnBark;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Die.started += instance.OnDie;
                @Die.performed += instance.OnDie;
                @Die.canceled += instance.OnDie;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public DogActions @Dog => new DogActions(this);
    public interface IPlayerActions
    {
        void OnFire(InputAction.CallbackContext context);
    }
    public interface IDogActions
    {
        void OnBark(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnDie(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
