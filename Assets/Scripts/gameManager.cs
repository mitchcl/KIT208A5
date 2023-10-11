using OVR.OpenVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    [SerializeField] private int doorCount = 42;

    private void OnEnable()
    {
        debugScript.openButtonPressed += addToCount;

    }

    private void OnDisable()
    {
        debugScript.openButtonPressed -= addToCount;
    }

    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void addToCount (){

    }


}
