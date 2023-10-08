using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugScript : MonoBehaviour
{

    public static event Action openButtonPressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            // Perform your desired action here
            Debug.Log("The 'A' button on the Oculus Quest 2 controller was pressed.");
            // Add your custom logic here
            openButtonPressed.Invoke();

        }
    }
}

