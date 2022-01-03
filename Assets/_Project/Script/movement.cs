using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    //private GameObject manager;
    private InputManager IM;
    private static shapes[] _shapesArray;

    public shapes[] GetShapes()
    {
        return _shapesArray;
    }

    private void Start()
    {
        Debug.Log("Init");
        IM = GameObject.FindWithTag("GameController").GetComponent<InputManager>();
        Debug.Assert(IM != null, "Could not load InputManager");

        _shapesArray = FindObjectsOfType<shapes>();
        Debug.Assert(_shapesArray.Length <= 4, "Somethings wrong with the shapes");
    }

    // Update is called once per frame
    void Update()
    {
        if (IM.LeftPButtonPressed)
        {
            Debug.Log("hi");
            for (int i = 0; i < _shapesArray.Length; i++)
            {
                Debug.Log(_shapesArray[i].gameObject.transform.position);
                _shapesArray[i].gameObject.transform.position = new Vector3(0,0.5f,0);
                Debug.Log(i + ", " + _shapesArray[i].gameObject.transform.position);
            }
            IM.LeftPButtonPressed = false;

        }
    }
}
