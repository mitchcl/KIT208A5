using System;
using UnityEngine;
using static TakePicture;

public class Tick : MonoBehaviour
{
    public GameObject targetObject2Activate;
    public GameObject targetObjectBecomeInactive;
    public static event Action reportTick;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (!targetObjectBecomeInactive.activeSelf && !targetObject2Activate.activeSelf)
        {
            targetObject2Activate.SetActive(true);

            reportTick.Invoke();

        }
    }
}