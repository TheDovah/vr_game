// GENERATED AUTOMATICALLY FROM 'Assets/_Project/Script/Input/GenericXRController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GenericXRController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GenericXRController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GenericXRController"",
    ""maps"": [
        {
            ""name"": ""RightController"",
            ""id"": ""32810bf5-fdd2-4be4-a7f6-6db620225591"",
            ""actions"": [
                {
                    ""name"": ""Grip"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b3c54064-f998-4050-8ace-d092dd017f5e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Trigger"",
                    ""type"": ""PassThrough"",
                    ""id"": ""02185ffd-3df7-40e8-a98b-66ccd77ce6b3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ea9f7173-6fa0-40f6-83be-ea6a5b9e1dfe"",
                    ""path"": ""<XRController>{RightHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d29822c-7e0d-4964-bc14-2d3d813becda"",
                    ""path"": ""<XRController>{RightHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""LeftController"",
            ""id"": ""dc0fcf98-52cc-4daf-8b63-a8aba00f9db9"",
            ""actions"": [
                {
                    ""name"": ""Grip"",
                    ""type"": ""PassThrough"",
                    ""id"": ""483c38ec-82ee-4ac7-9d5d-d1d60c7bdf23"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Trigger"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9e9df73c-27a0-4913-8477-803c69e4f8c5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c8cea138-1396-4468-ad4a-cb670d093545"",
                    ""path"": ""<XRController>{LeftHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2167cefd-83c5-4fea-be9d-557650960392"",
                    ""path"": ""<XRController>{LeftHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // RightController
        m_RightController = asset.FindActionMap("RightController", throwIfNotFound: true);
        m_RightController_Grip = m_RightController.FindAction("Grip", throwIfNotFound: true);
        m_RightController_Trigger = m_RightController.FindAction("Trigger", throwIfNotFound: true);
        // LeftController
        m_LeftController = asset.FindActionMap("LeftController", throwIfNotFound: true);
        m_LeftController_Grip = m_LeftController.FindAction("Grip", throwIfNotFound: true);
        m_LeftController_Trigger = m_LeftController.FindAction("Trigger", throwIfNotFound: true);
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

    // RightController
    private readonly InputActionMap m_RightController;
    private IRightControllerActions m_RightControllerActionsCallbackInterface;
    private readonly InputAction m_RightController_Grip;
    private readonly InputAction m_RightController_Trigger;
    public struct RightControllerActions
    {
        private @GenericXRController m_Wrapper;
        public RightControllerActions(@GenericXRController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grip => m_Wrapper.m_RightController_Grip;
        public InputAction @Trigger => m_Wrapper.m_RightController_Trigger;
        public InputActionMap Get() { return m_Wrapper.m_RightController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightControllerActions set) { return set.Get(); }
        public void SetCallbacks(IRightControllerActions instance)
        {
            if (m_Wrapper.m_RightControllerActionsCallbackInterface != null)
            {
                @Grip.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnGrip;
                @Grip.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnGrip;
                @Grip.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnGrip;
                @Trigger.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnTrigger;
                @Trigger.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnTrigger;
                @Trigger.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnTrigger;
            }
            m_Wrapper.m_RightControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grip.started += instance.OnGrip;
                @Grip.performed += instance.OnGrip;
                @Grip.canceled += instance.OnGrip;
                @Trigger.started += instance.OnTrigger;
                @Trigger.performed += instance.OnTrigger;
                @Trigger.canceled += instance.OnTrigger;
            }
        }
    }
    public RightControllerActions @RightController => new RightControllerActions(this);

    // LeftController
    private readonly InputActionMap m_LeftController;
    private ILeftControllerActions m_LeftControllerActionsCallbackInterface;
    private readonly InputAction m_LeftController_Grip;
    private readonly InputAction m_LeftController_Trigger;
    public struct LeftControllerActions
    {
        private @GenericXRController m_Wrapper;
        public LeftControllerActions(@GenericXRController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grip => m_Wrapper.m_LeftController_Grip;
        public InputAction @Trigger => m_Wrapper.m_LeftController_Trigger;
        public InputActionMap Get() { return m_Wrapper.m_LeftController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftControllerActions set) { return set.Get(); }
        public void SetCallbacks(ILeftControllerActions instance)
        {
            if (m_Wrapper.m_LeftControllerActionsCallbackInterface != null)
            {
                @Grip.started -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnGrip;
                @Grip.performed -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnGrip;
                @Grip.canceled -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnGrip;
                @Trigger.started -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnTrigger;
                @Trigger.performed -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnTrigger;
                @Trigger.canceled -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnTrigger;
            }
            m_Wrapper.m_LeftControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grip.started += instance.OnGrip;
                @Grip.performed += instance.OnGrip;
                @Grip.canceled += instance.OnGrip;
                @Trigger.started += instance.OnTrigger;
                @Trigger.performed += instance.OnTrigger;
                @Trigger.canceled += instance.OnTrigger;
            }
        }
    }
    public LeftControllerActions @LeftController => new LeftControllerActions(this);
    public interface IRightControllerActions
    {
        void OnGrip(InputAction.CallbackContext context);
        void OnTrigger(InputAction.CallbackContext context);
    }
    public interface ILeftControllerActions
    {
        void OnGrip(InputAction.CallbackContext context);
        void OnTrigger(InputAction.CallbackContext context);
    }
}
