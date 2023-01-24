//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/_scripts/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""9c04e13a-ecc6-40fa-9ac9-ae7c32d7fbaa"",
            ""actions"": [
                {
                    ""name"": ""Ride"",
                    ""type"": ""Value"",
                    ""id"": ""a7387ea7-08a8-4f9b-bf4d-5eeaedd9112d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""09a0bc39-0347-4afa-9640-83143f79774e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a9cce1b0-faa1-42c3-8dc5-d82fe4386b7a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardPC"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""20b7df42-df8b-4b60-9c48-4ca407ad1b6e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ride"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""adff7c59-31e6-4ea8-ac07-7af7a539f984"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardPC"",
                    ""action"": ""Ride"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""00ad81bf-5753-4858-a936-2975e2e43ebd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardPC"",
                    ""action"": ""Ride"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e808f713-1276-45f3-97ac-9b661e60b8fd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardPC"",
                    ""action"": ""Ride"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7f3999a6-f1b6-4a27-a060-a11eba30bfaf"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardPC"",
                    ""action"": ""Ride"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardPC"",
            ""bindingGroup"": ""KeyboardPC"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""AndroidSonsor"",
            ""bindingGroup"": ""AndroidSonsor"",
            ""devices"": []
        }
    ]
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Ride = m_Player1.FindAction("Ride", throwIfNotFound: true);
        m_Player1_Shoot = m_Player1.FindAction("Shoot", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Ride;
    private readonly InputAction m_Player1_Shoot;
    public struct Player1Actions
    {
        private @PlayerInput m_Wrapper;
        public Player1Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Ride => m_Wrapper.m_Player1_Ride;
        public InputAction @Shoot => m_Wrapper.m_Player1_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @Ride.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRide;
                @Ride.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRide;
                @Ride.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRide;
                @Shoot.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Ride.started += instance.OnRide;
                @Ride.performed += instance.OnRide;
                @Ride.canceled += instance.OnRide;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);
    private int m_KeyboardPCSchemeIndex = -1;
    public InputControlScheme KeyboardPCScheme
    {
        get
        {
            if (m_KeyboardPCSchemeIndex == -1) m_KeyboardPCSchemeIndex = asset.FindControlSchemeIndex("KeyboardPC");
            return asset.controlSchemes[m_KeyboardPCSchemeIndex];
        }
    }
    private int m_AndroidSonsorSchemeIndex = -1;
    public InputControlScheme AndroidSonsorScheme
    {
        get
        {
            if (m_AndroidSonsorSchemeIndex == -1) m_AndroidSonsorSchemeIndex = asset.FindControlSchemeIndex("AndroidSonsor");
            return asset.controlSchemes[m_AndroidSonsorSchemeIndex];
        }
    }
    public interface IPlayer1Actions
    {
        void OnRide(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}
