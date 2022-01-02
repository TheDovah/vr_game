using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    //private GameObject manager;
    private InputManager IM;

    private void Start()
    {
        Debug.Log("Init");
        IM = GameObject.FindWithTag("GameController").GetComponent<InputManager>();
        Debug.Assert(IM != null, "Could not load InputManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (IM.LeftPButtonPressed)
        {
            Debug.Log(this + " is this");
            GameObject.FindWithTag("Player").transform.parent.gameObject.transform.forward.Set(0, 87, 0);
            Debug.Log("hmmmm");
        }
    }
}
