
using System;
using UnityEngine;

public class Grabbing : MonoBehaviour
{
    //private GameObject manager;
    private InputManager IM;

    private void Start()
    {
        Debug.Log("Init");
        IM = GameObject.FindWithTag("GameController").GetComponent<InputManager>();
        Debug.Assert(IM != null, "Could not load InputManager");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.LogFormat("rightGripPressed: {0}, rightTriggerPressed: {1}", IM.rightGripPressed, IM.rightTriggerPressed);
        if (other.gameObject.GetComponent<Grabable>() == null) return;
        if (IM.rightGripPressed)
        {
            Debug.Log("grabbing a grabable object");
            other.transform.parent = this.transform;
            other.GetComponent<Rigidbody>().isKinematic = true;
        }
        else if (IM.rightTriggerPressed)
        {
            Debug.Log("releasing my prisoner");
            other.transform.parent = null;
            other.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
