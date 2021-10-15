// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/PinballControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PinballControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PinballControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PinballControls"",
    ""maps"": [
        {
            ""name"": ""Pinball"",
            ""id"": ""aa9ae2fd-5760-4ae4-9598-68ca88c42f0b"",
            ""actions"": [
                {
                    ""name"": ""LeftFlipper"",
                    ""type"": ""Button"",
                    ""id"": ""3e793bd5-e376-49a2-a167-ca2799036900"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightFlipper"",
                    ""type"": ""Button"",
                    ""id"": ""2b0575fb-d2c9-4b53-bee3-abb500419dab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Plunger"",
                    ""type"": ""Button"",
                    ""id"": ""4a05e39d-9cac-466b-a3b6-fda533eab16c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""88e550f3-fe9d-4f68-b2a3-d894154268fb"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pinball"",
                    ""action"": ""LeftFlipper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23ff2842-80c7-44ab-8758-31b1a379448c"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pinball"",
                    ""action"": ""RightFlipper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a698c2e-cec8-4e21-8e8f-fa1e9b1a1f4f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pinball"",
                    ""action"": ""Plunger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Pinball"",
            ""bindingGroup"": ""Pinball"",
            ""devices"": []
        }
    ]
}");
        // Pinball
        m_Pinball = asset.FindActionMap("Pinball", throwIfNotFound: true);
        m_Pinball_LeftFlipper = m_Pinball.FindAction("LeftFlipper", throwIfNotFound: true);
        m_Pinball_RightFlipper = m_Pinball.FindAction("RightFlipper", throwIfNotFound: true);
        m_Pinball_Plunger = m_Pinball.FindAction("Plunger", throwIfNotFound: true);
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

    // Pinball
    private readonly InputActionMap m_Pinball;
    private IPinballActions m_PinballActionsCallbackInterface;
    private readonly InputAction m_Pinball_LeftFlipper;
    private readonly InputAction m_Pinball_RightFlipper;
    private readonly InputAction m_Pinball_Plunger;
    public struct PinballActions
    {
        private @PinballControls m_Wrapper;
        public PinballActions(@PinballControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftFlipper => m_Wrapper.m_Pinball_LeftFlipper;
        public InputAction @RightFlipper => m_Wrapper.m_Pinball_RightFlipper;
        public InputAction @Plunger => m_Wrapper.m_Pinball_Plunger;
        public InputActionMap Get() { return m_Wrapper.m_Pinball; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PinballActions set) { return set.Get(); }
        public void SetCallbacks(IPinballActions instance)
        {
            if (m_Wrapper.m_PinballActionsCallbackInterface != null)
            {
                @LeftFlipper.started -= m_Wrapper.m_PinballActionsCallbackInterface.OnLeftFlipper;
                @LeftFlipper.performed -= m_Wrapper.m_PinballActionsCallbackInterface.OnLeftFlipper;
                @LeftFlipper.canceled -= m_Wrapper.m_PinballActionsCallbackInterface.OnLeftFlipper;
                @RightFlipper.started -= m_Wrapper.m_PinballActionsCallbackInterface.OnRightFlipper;
                @RightFlipper.performed -= m_Wrapper.m_PinballActionsCallbackInterface.OnRightFlipper;
                @RightFlipper.canceled -= m_Wrapper.m_PinballActionsCallbackInterface.OnRightFlipper;
                @Plunger.started -= m_Wrapper.m_PinballActionsCallbackInterface.OnPlunger;
                @Plunger.performed -= m_Wrapper.m_PinballActionsCallbackInterface.OnPlunger;
                @Plunger.canceled -= m_Wrapper.m_PinballActionsCallbackInterface.OnPlunger;
            }
            m_Wrapper.m_PinballActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftFlipper.started += instance.OnLeftFlipper;
                @LeftFlipper.performed += instance.OnLeftFlipper;
                @LeftFlipper.canceled += instance.OnLeftFlipper;
                @RightFlipper.started += instance.OnRightFlipper;
                @RightFlipper.performed += instance.OnRightFlipper;
                @RightFlipper.canceled += instance.OnRightFlipper;
                @Plunger.started += instance.OnPlunger;
                @Plunger.performed += instance.OnPlunger;
                @Plunger.canceled += instance.OnPlunger;
            }
        }
    }
    public PinballActions @Pinball => new PinballActions(this);
    private int m_PinballSchemeIndex = -1;
    public InputControlScheme PinballScheme
    {
        get
        {
            if (m_PinballSchemeIndex == -1) m_PinballSchemeIndex = asset.FindControlSchemeIndex("Pinball");
            return asset.controlSchemes[m_PinballSchemeIndex];
        }
    }
    public interface IPinballActions
    {
        void OnLeftFlipper(InputAction.CallbackContext context);
        void OnRightFlipper(InputAction.CallbackContext context);
        void OnPlunger(InputAction.CallbackContext context);
    }
}
