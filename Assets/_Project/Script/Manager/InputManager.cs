using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class InputManager : MonoBehaviour
{
    private GenericXRController inputActions;
    [SerializeField] private Vector2 min_max_valueTreshold = new Vector2(0.1f, 0.9f);

    public static UnityEvent OnGripLeftHandPressed = new UnityEvent();
    public static UnityEvent<float> OnGripLefthandUpdated = new UnityEvent<float>();
    public static UnityEvent OnGripLeftHandReleased = new UnityEvent();
    
    public static UnityEvent OnTriggerLeftHandPressed = new UnityEvent();
    public static UnityEvent<float> OnTriggerLefthandUpdated = new UnityEvent<float>();
    public static UnityEvent OnTriggerLeftHandReleased = new UnityEvent();
    
    public static UnityEvent OnPButtonLeftHandPressed = new UnityEvent();
    public static UnityEvent<float> OnPButtonLefthandUpdated = new UnityEvent<float>();
    public static UnityEvent OnPButtonLeftHandReleased = new UnityEvent();
    
    public static UnityEvent OnGripRightHandPressed = new UnityEvent();
    public static UnityEvent<float> OnGripRighthandUpdated = new UnityEvent<float>();
    public static UnityEvent OnGripRightHandReleased = new UnityEvent();
    
    public static UnityEvent OnTriggerRightHandPressed = new UnityEvent();
    public static UnityEvent<float> OnTriggerRighthandUpdated = new UnityEvent<float>();
    public static UnityEvent OnTriggerRightHandReleased = new UnityEvent();

    private float leftHandGripValue;
    private float rightHandGripValue;
    private float leftHandTriggerValue;
    private float rightHandTriggerValue;

    protected bool leftGripPressed;
    public bool rightGripPressed = false;
    
    protected bool leftTriggerPressed;
    public bool rightTriggerPressed;

    public bool LeftPButtonPressed;

    public static InputManager instance;
    private void Awake()
    {
        // making the class a Singleton, to be safe
        if (instance != null) {
            Debug.Log("An instance already exists, deleting...");
            Destroy(gameObject);
        }else {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log($"Setting {this} to DontDestroyOnLoad");
        }
        
        inputActions = new GenericXRController();
        inputActions.RightController.Grip.performed += PressGripR;
        inputActions.RightController.Trigger.performed += PressTriggerR;
        inputActions.LeftController.Grip.performed += PressGripL;
        inputActions.LeftController.Trigger.performed += PressTriggerL;
        inputActions.LeftController.A_button.performed += PressPButtonL;
        inputActions.Enable();
    }
    
    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void OnDestroy()
    {
        inputActions.Dispose();
    }
    
    private void PressGripR(InputAction.CallbackContext obj)
    {
        rightHandGripValue = obj.ReadValue<float>();
        if (rightHandGripValue > min_max_valueTreshold.x && rightHandGripValue < min_max_valueTreshold.y)
        {
            OnGripRighthandUpdated.Invoke(rightHandGripValue);
        }

        if (!rightGripPressed && rightHandGripValue > min_max_valueTreshold.y)
        {
            OnGripRightHandPressed.Invoke();
            rightGripPressed = true;
            Debug.Log("You Pressed the right hand grip");
        }

        if (rightGripPressed && rightHandGripValue < min_max_valueTreshold.x)
        {
            OnGripRightHandReleased.Invoke();
            rightGripPressed = false;
            Debug.Log("You Released the right hand grip");
        }
    }

    private void PressTriggerR(InputAction.CallbackContext obj)
    {
        rightHandTriggerValue = obj.ReadValue<float>();
        if (rightHandTriggerValue > min_max_valueTreshold.x && rightHandTriggerValue < min_max_valueTreshold.y)
        {
            OnTriggerRighthandUpdated.Invoke(rightHandTriggerValue);
        }

        if (!rightTriggerPressed && rightHandTriggerValue > min_max_valueTreshold.y)
        {
            OnTriggerRightHandPressed.Invoke();
            rightTriggerPressed = true;
            Debug.Log("You Pressed the right hand Trigger");
        }

        if (rightTriggerPressed && rightHandTriggerValue < min_max_valueTreshold.x)
        {
            OnTriggerRightHandReleased.Invoke();
            rightTriggerPressed = false;
            Debug.Log("You Released the right hand Trigger");
        }
    }

    private void PressGripL(InputAction.CallbackContext obj)
    {
        leftHandGripValue = obj.ReadValue<float>();
        if (leftHandGripValue > min_max_valueTreshold.x && leftHandGripValue < min_max_valueTreshold.y)
        {
            OnGripLefthandUpdated.Invoke(leftHandGripValue);
        }

        if (!leftGripPressed && leftHandGripValue > min_max_valueTreshold.y)
        {
            OnGripLeftHandPressed.Invoke();
            leftGripPressed = true;
            Debug.Log("You Pressed the left hand grip");
        }

        if (leftGripPressed && leftHandGripValue < min_max_valueTreshold.x)
        {
            OnGripLeftHandReleased.Invoke();
            leftGripPressed = false;
            Debug.Log("You Released the left hand grip");
        }
    }

    private void PressTriggerL(InputAction.CallbackContext obj)
    {
        leftHandTriggerValue = obj.ReadValue<float>();
        if (leftHandTriggerValue > min_max_valueTreshold.x && leftHandTriggerValue < min_max_valueTreshold.y)
        {
            OnTriggerLefthandUpdated.Invoke(leftHandTriggerValue);
        }

        if (!leftTriggerPressed && leftHandTriggerValue > min_max_valueTreshold.y)
        {
            OnTriggerLeftHandPressed.Invoke();
            leftTriggerPressed = true;
            Debug.Log("You Pressed the Left hand Trigger");
        }

        if (leftTriggerPressed && leftHandTriggerValue < min_max_valueTreshold.x)
        {
            OnTriggerLeftHandReleased.Invoke();
            leftTriggerPressed = false;
            Debug.Log("You Released the Left hand Trigger");
        }
    }

    private void PressPButtonL(InputAction.CallbackContext obj)
    {
        OnPButtonLeftHandPressed.Invoke();
        LeftPButtonPressed = true;
        Debug.Log("You pressed the Primary button on the left hand");
    }
}
