using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeBorder : MonoBehaviour
{
    private movement mov;
    // Start is called before the first frame update
    void Start()
    {
        mov = FindObjectOfType<movement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exiting trigger");
        Debug.Log(other.gameObject.tag);
        
        for (int i = 0; i < mov.GetShapes().Length; i++)
        {
            if (other.gameObject.tag == "shape")
            {
                Debug.Log("Moving shapes");
                other.gameObject.transform.position = new Vector3(0, 0.5f, 0);
            }
        }
    }   
}
