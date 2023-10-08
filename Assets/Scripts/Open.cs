using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Open : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private OpenTypes openDirection;
    [SerializeField] private float rotationSpeed = 5.0f; // Adjust this value to control the rotation speed
    [SerializeField] private bool isRotating = false;// Start is called before the first frame update
    [SerializeField] private bool isOpen = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            // Calculate the rotation needed to look at the target
            Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position);

            // Smoothly rotate towards the target rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Check if the object is close to the target rotation
            if (Quaternion.Angle(transform.rotation, targetRotation) < 1.0f)
            {
                // Stop rotating when close to the target rotation
                isRotating = false;
            }
        }
    }

    private void OnEnable()
    {
        debugScript.openButtonPressed += openDoor;
    }

    private void OnDisable()
    {
        debugScript.openButtonPressed -= openDoor;
    }

    public void openDoor(){ 
        if (openDirection == OpenTypes.ROTATEUP)
        {
            if (isOpen == false)
            {
                Debug.Log("door open.");
                transform.Rotate(0.0f, 0.0f, 80.0f);
            }else if (isOpen == true)
            {
                Debug.Log("door closed.");
                transform.Rotate(0.0f, 0.0f, 0.0f);
            }
            

        }
        else if (openDirection == OpenTypes.ROTATEDOWN)
        {

        }else if (openDirection == OpenTypes.ROTATELEFT)
        {

        }else if (openDirection == OpenTypes.ROTATERIGHT)
        {

        }else if (openDirection == OpenTypes.SLIDEPOSX)
        {

        }else if (openDirection == OpenTypes.SLIDENEGX)
        {

        }else if (openDirection == OpenTypes.SLIDEPOSZ)
        {

        }else if (openDirection == OpenTypes.SLIDENEGZ)
        {

        }
    }
}
