using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagEvidence : MonoBehaviour
{
    public GameObject bagRayOrigin0;
    public GameObject bagRayOrigin1;
    public GameObject bagRayOrigin2;
    public GameObject bagRayOrigin3;
    public GameObject bagRayOrigin4;
    public float raycastDistance; // Maximum distance for the raycast

    private InventoryController inventoryController; // Reference to the InventoryController

    public delegate void BaggedEvidenceAction(bool hasTakenPicture);
    public static event BaggedEvidenceAction reportBaggedEvidence;
    void Start()
    {
        inventoryController = GetComponent<InventoryController>();
    }

    private void Update()
    {
        if(inventoryController.CurrentItemIsEvidenceBag() && OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            bool triggered = false;
            Debug.Log("SecondaryIndexTrigger");
            // When the trigger is pulled, cast a ray from the Oculus controller
            //Ray ray = new Ray(ovrCameraRig.centerEyeAnchor.position, ovrCameraRig.centerEyeAnchor.forward);
            Ray ray0 = new Ray(bagRayOrigin1.transform.position, bagRayOrigin1.transform.forward);
            Ray ray1 = new Ray(bagRayOrigin1.transform.position, bagRayOrigin1.transform.forward);
            Ray ray2 = new Ray(bagRayOrigin2.transform.position, bagRayOrigin2.transform.forward);
            Ray ray3 = new Ray(bagRayOrigin3.transform.position, bagRayOrigin3.transform.forward);
            Ray ray4 = new Ray(bagRayOrigin4.transform.position, bagRayOrigin4.transform.forward);
            RaycastHit hit0;
            RaycastHit hit1;
            RaycastHit hit2;
            RaycastHit hit3;
            RaycastHit hit4;

            // Draw the ray for debugging
            Debug.DrawRay(ray0.origin, ray0.direction * raycastDistance, Color.cyan, 3.0f);
            Debug.DrawRay(ray1.origin, ray1.direction * raycastDistance, Color.cyan, 3.0f);
            Debug.DrawRay(ray2.origin, ray2.direction * raycastDistance, Color.cyan, 3.0f);
            Debug.DrawRay(ray3.origin, ray3.direction * raycastDistance, Color.cyan, 3.0f);
            Debug.DrawRay(ray4.origin, ray4.direction * raycastDistance, Color.cyan, 3.0f);

            Debug.Log("Did it hit sxomething:" + Physics.Raycast(ray1, out hit1, raycastDistance));
            // Debug.Log("Does it have EvidenceBox tag:" + hit.collider.CompareTag("EvidenceBox"));
            //Debug.Log("Name of Object:" + hit.collider.name);

            if ((Physics.Raycast(ray0, out hit0, raycastDistance)) && hit0.collider.CompareTag("Evidence") && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit0.collider.name);
                // Check the tag of the raycast hit object and call the "OpenUp" function
                // hit0.collider.gameObject.SendMessage("Evidence", SendMessageOptions.DontRequireReceiver);
                BagEvidence.reportBaggedEvidence?.Invoke(true);
                hit0.collider.gameObject.SetActive(false);
                triggered = true;
            }
            else if ((Physics.Raycast(ray1, out hit1, raycastDistance)) && hit1.collider.CompareTag("Evidence") && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit1.collider.name);
                // Check the tag of the raycast hit object and call the "OpenUp" function
                //  hit1.collider.gameObject.SendMessage("OpenUp", SendMessageOptions.DontRequireReceiver);
                hit1.collider.gameObject.SetActive(false);
                BagEvidence.reportBaggedEvidence?.Invoke(true);
                triggered = true;
            }
            else if (((Physics.Raycast(ray2, out hit2, raycastDistance)) && hit2.collider.CompareTag("Evidence")) && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit2.collider.name);
                // hit2.collider.gameObject.SendMessage("OpenUp", SendMessageOptions.DontRequireReceiver);
                hit2.collider.gameObject.SetActive(false);
                BagEvidence.reportBaggedEvidence?.Invoke(true);
                triggered = true;
            }
            else if (((Physics.Raycast(ray3, out hit3, raycastDistance)) && hit3.collider.CompareTag("Evidence")) && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit3.collider.name);
                // hit3.collider.gameObject.SendMessage("OpenUp", SendMessageOptions.DontRequireReceiver);
                hit3.collider.gameObject.SetActive(false);
                BagEvidence.reportBaggedEvidence?.Invoke(true);
                //  triggered = true;
            }
            else if (((Physics.Raycast(ray4, out hit4, raycastDistance)) && hit4.collider.CompareTag("Evidence")) && (triggered == false))
            {
                Debug.Log("Name of Object:" + hit4.collider.name);
                hit4.collider.gameObject.SetActive(false);
                BagEvidence.reportBaggedEvidence?.Invoke(true);
                // hit4.collider.gameObject.SendMessage("OpenUp", SendMessageOptions.DontRequireReceiver);
                triggered = true;
            }
        }
    }
}
