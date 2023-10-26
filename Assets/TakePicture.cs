using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePicture : MonoBehaviour
{
    public GameObject cameraRayOrigin0;
    public GameObject cameraRayOrigin1;
    public GameObject cameraRayOrigin2;
    public GameObject cameraRayOrigin3;
    public GameObject cameraRayOrigin4;
    public float raycastDistance; // Maximum distance for the raycast
    private InventoryController inventoryController; // Reference to the InventoryController
    public GameObject UvLight;
    private Boolean UVON = false;
    [SerializeField] private AudioSource shutterSoundEffect;

    public delegate void PictureTakenAction(bool hasTakenPicture);
    public static event PictureTakenAction reportPictureTaken;

    void Start()
    {
        inventoryController = GetComponent<InventoryController>();
    }


    private void Update()
    {
        



        if (inventoryController.CurrentItemIsCamera() && OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            bool triggered = false;
            Debug.Log("SecondaryIndexTrigger");
            // When the trigger is pulled, cast a ray from the Oculus controller
            //Ray ray = new Ray(ovrCameraRig.centerEyeAnchor.position, ovrCameraRig.centerEyeAnchor.forward);
            Ray ray0 = new Ray(cameraRayOrigin1.transform.position, cameraRayOrigin1.transform.forward);
            Ray ray1 = new Ray(cameraRayOrigin1.transform.position, cameraRayOrigin1.transform.forward);
            Ray ray2 = new Ray(cameraRayOrigin2.transform.position, cameraRayOrigin2.transform.forward);
            Ray ray3 = new Ray(cameraRayOrigin3.transform.position, cameraRayOrigin3.transform.forward);
            Ray ray4 = new Ray(cameraRayOrigin4.transform.position, cameraRayOrigin4.transform.forward);
            RaycastHit hit0;
            RaycastHit hit1;
            RaycastHit hit2;
            RaycastHit hit3;
            RaycastHit hit4;

            // Draw the ray for debugging
            Debug.DrawRay(ray0.origin, ray0.direction * raycastDistance, Color.blue, 3.0f);
            Debug.DrawRay(ray1.origin, ray1.direction * raycastDistance, Color.blue, 3.0f);
            Debug.DrawRay(ray2.origin, ray2.direction * raycastDistance, Color.blue, 3.0f);
            Debug.DrawRay(ray3.origin, ray3.direction * raycastDistance, Color.blue, 3.0f);
            Debug.DrawRay(ray4.origin, ray4.direction * raycastDistance, Color.blue, 3.0f);

            Debug.Log("Did it hit sxomething:" + Physics.Raycast(ray1, out hit1, raycastDistance));
            // Debug.Log("Does it have EvidenceBox tag:" + hit.collider.CompareTag("EvidenceBox"));
            //Debug.Log("Name of Object:" + hit.collider.name);

            if ((Physics.Raycast(ray0, out hit0, raycastDistance)) && hit0.collider.CompareTag("EvidenceBox") && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit0.collider.name);
                // Check the tag of the raycast hit object and call the "OpenUp" function
                // hit0.collider.gameObject.SendMessage("Evidence", SendMessageOptions.DontRequireReceiver);
                hit0.collider.gameObject.SetActive(false);
                TakePicture.reportPictureTaken?.Invoke(true);
                shutterSoundEffect.Play();
                triggered = true;
            }
            else if ((Physics.Raycast(ray1, out hit1, raycastDistance)) && hit1.collider.CompareTag("EvidenceBox") && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit1.collider.name);
                // Check the tag of the raycast hit object and call the "OpenUp" function
                //  hit1.collider.gameObject.SendMessage("OpenUp", SendMessageOptions.DontRequireReceiver);
                TakePicture.reportPictureTaken?.Invoke(true);
                hit1.collider.gameObject.SetActive(false);
                shutterSoundEffect.Play();
                triggered = true;
            }
            else if (((Physics.Raycast(ray2, out hit2, raycastDistance)) && hit2.collider.CompareTag("EvidenceBox")) && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit2.collider.name);
                // hit2.collider.gameObject.SendMessage("OpenUp", SendMessageOptions.DontRequireReceiver);
                TakePicture.reportPictureTaken?.Invoke(true);
                hit2.collider.gameObject.SetActive(false);
                shutterSoundEffect.Play();
                triggered = true;
            }
            else if (((Physics.Raycast(ray3, out hit3, raycastDistance)) && hit3.collider.CompareTag("EvidenceBox")) && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit3.collider.name);
                // hit3.collider.gameObject.SendMessage("OpenUp", SendMessageOptions.DontRequireReceiver);
                TakePicture.reportPictureTaken?.Invoke(true);
                hit3.collider.gameObject.SetActive(false);
                shutterSoundEffect.Play();
                //  triggered = true;
            }
            else if (((Physics.Raycast(ray4, out hit4, raycastDistance)) && hit4.collider.CompareTag("EvidenceBox")) && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit4.collider.name);
                hit4.collider.gameObject.SetActive(false);
                // hit4.collider.gameObject.SendMessage("OpenUp", SendMessageOptions.DontRequireReceiver);
                TakePicture.reportPictureTaken?.Invoke(true);
                shutterSoundEffect.Play();
                triggered = true;
            }
        }
    }
}
